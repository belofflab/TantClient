using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TantClient
{
    public partial class TantClient : Form
    {
        private AdminInfo adminInformation;
        private Worker[] workersInformation;
        private PaymentDetail[] paymentDetails;
        private Button currentButton;
        private Form activeForm;
        public TantClient()
        {
            InitializeComponent();
            loadData();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public class AdminInfo
        {
            public double total { get; set; }
            public double marginal { get; set; }
            public double owed { get; set; }
        }

        public class Proxy
        {
            public long id { get; set; }
            public string host { get; set; }
            public string port { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string scheme { get; set; }

        }

        public class Worker
        {
            public long id { get; set; }
            public string username { get; set; }
            public string name { get; set; }
            public double amount { get; set; }
            public double freezed_amount { get; set; }
            public int comission { get; set; }
            private int api_id { get; set; }
            private string api_hash { get; set; }
            public string hostname { get; set; }
            public string subdomain { get; set; }
            public Boolean is_active { get; set; }
            public DateTime created_at { get; set; }
            private Proxy proxy { get; set; }
        }

        public class PaymentDetail
        {
            public int id { get; set; }
            public string name { get; set; }
            public string text { get; set; }
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
            adminInformation = null;
            workersInformation = null;
            paymentDetails = null;
            getAdminData();
            getWorkers();
            getPaymentDetails();
        }
        private async void getAdminData()
        {
            richTextBoxBaseInfo.Clear();
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://tant.belofflab.com/api/v1/admin/info/");
            adminInformation = JsonConvert.DeserializeObject<AdminInfo>(json);
            richTextBoxBaseInfo.Text = "Общий доход: " + adminInformation.total.ToString() + "₽" + "\n" +
                                       "Маржа: " + adminInformation.marginal.ToString() + "₽" + "\n" +
                                       "Долг работникам: " + adminInformation.owed.ToString() + "₽" + "\n";
        }
        private async void getWorkers()
        {
            richTextBoxWorkers.Clear();
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://tant.belofflab.com/api/v1/workers/");
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
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://tant.belofflab.com/api/v1/admin/payment/details/");
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
