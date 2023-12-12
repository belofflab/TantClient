using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TantClient.Models;
using TantClient.Services;

namespace TantClient
{
    public partial class TantClient : Form
    {
        private readonly AdminService _adminService;
        private readonly WorkerService _workerService;
        private ProjectInfo projectInfo;
        private Worker[] workersInformation;
        private PaymentDetail[] paymentDetails;
        private Button currentButton;
        private Form activeForm;
        public TantClient()
        {
            InitializeComponent();
            _adminService = new AdminService();
            _workerService = new WorkerService();
            loadData();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.WhiteSmoke;
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                previousBtn.ForeColor = Color.Black;
            }
        }

        private void loadData()
        {
            projectInfo = null;
            workersInformation = null;
            paymentDetails = null;
            getAdminData();
            getWorkers();
            getPaymentDetails();
        }
        private async void getAdminData()
        {
            richTextBoxBaseInfo.Clear();
            string json = await _adminService.getProjectInfo();
            projectInfo = JsonConvert.DeserializeObject<ProjectInfo>(json);
            richTextBoxBaseInfo.Text = "Общий доход: " + projectInfo.total.ToString() + "₽" + "\n" +
                                       "Маржа: " + projectInfo.marginal.ToString() + "₽" + "\n" +
                                       "Долг работникам: " + projectInfo.owed.ToString() + "₽" + "\n";
        }
        private async void getWorkers()
        {
            richTextBoxWorkers.Clear();
            string json = await _workerService.getWorkers();
            workersInformation = JsonConvert.DeserializeObject<Worker[]>(json);

            var SortedWorkers = workersInformation.OrderByDescending(worker => worker.amount).ToArray();

            for (int i = 0; i < SortedWorkers.Length; i++)
            {
                Worker worker = SortedWorkers[i];
                string line = $"{i + 1}. {worker.name}: {worker.amount}₽\n";

                if (i < 3)
                {
                    richTextBoxWorkers.SelectionFont = new Font(richTextBoxWorkers.Font, FontStyle.Bold);
                    richTextBoxWorkers.AppendText(line);
                    richTextBoxWorkers.SelectionFont = new Font(richTextBoxWorkers.Font, FontStyle.Regular);
                }
                else
                {
                    richTextBoxWorkers.AppendText(line);
                }
            }
        }
        private async void getPaymentDetails()
        {
            richTextBoxPaymentDetails.Clear();
            string json = await _adminService.getPaymentDetails();
            paymentDetails = JsonConvert.DeserializeObject<PaymentDetail[]>(json);

            for (int i = 0; i < paymentDetails.Length; i++)
            {
                PaymentDetail paymentDetail = paymentDetails[i];
                string line = $"{i + 1}. {paymentDetail.name}: {paymentDetail.text}₽\n";
                richTextBoxPaymentDetails.AppendText(line);
            }
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHeader.Text = childForm.Text;
        }

        private void buttonAnalytics_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormAnalytics(), sender);
        }

        private void buttonTurnover_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormCashTurnover(), sender);
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormWorkers(), sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            labelHeader.Text = "Основная информация о проекте";
            currentButton = null;
            panelLogo.BackColor = Color.FromArgb(41, 47, 51);
            btnCloseChildForm.Visible = false;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonUpdateBaseInfo_Click(object sender, EventArgs e)
        {
            buttonUpdateBaseInfo.Cursor = Cursors.WaitCursor;
            loadData();
            buttonUpdateBaseInfo.Cursor = Cursors.Hand;

        }
    }
}
