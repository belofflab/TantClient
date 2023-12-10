using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TantClient.Forms.FormAnalytics;

namespace TantClient.Forms
{
    public partial class FormWorkers : Form
    {

        public FormWorkers()
        {
            InitializeComponent();
            loadWorkers();
        }
        public class Proxy
        {
            public int id { get; set; }
        }
        public class WorkerData
        {
            public object id { get; set; }
            public string username { get; set; }
            public string name { get; set; }
            public double? amount { get; set; }
            public double freezed_amount { get; set; }
            public int comission { get; set; }
            public int api_id { get; set; }
            public string api_hash { get; set; }
            public object subdomain { get; set; }
            public string hostname { get; set; }
            public bool is_active { get; set; }
            public DateTime created_at { get; set; }
            public Proxy proxy { get; set; }
            public List<object> workerrequests { get; set; }
        }
        private WorkerData[] workers;

        private async void loadWorkers()
        {
            string apiUrl = "https://tant.belofflab.com/api/v1/workers/";

            HttpClient client = new HttpClient();

            string json = await client.GetStringAsync(apiUrl);
            workers = JsonConvert.DeserializeObject<WorkerData[]>(json);
            listBoxWorkers.DisplayMember = "name";
            listBoxWorkers.DataSource = workers;
        }

        private void listBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItem != null)
            {
                richTextBoxChoosenWorker.Clear();
                WorkerData selectedWorker = (WorkerData)listBoxWorkers.SelectedItem;
                richTextBoxChoosenWorker.AppendText($"Выбранный сотрудник: {selectedWorker.name}\n");
                richTextBoxChoosenWorker.AppendText($"Баланс: {selectedWorker.amount}₽\n");
                richTextBoxChoosenWorker.AppendText($"Замороженный баланс: {selectedWorker.freezed_amount}₽\n");
                richTextBoxChoosenWorker.AppendText($"Комиссия: {selectedWorker.comission}%\n");
            }
        }

        private void buttonPenalty_Click(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItem != null)
            {
                WorkerData selectedWorker = (WorkerData)listBoxWorkers.SelectedItem;

                using (InputAmountForm popupForm = new InputAmountForm())
                {
                    if (popupForm.ShowDialog() == DialogResult.OK)
                    {
                        decimal amount = popupForm.Amount;

                        MessageBox.Show($"Выдали штраф на сумму: {amount.ToString()}₽");
                    }
                }
            }
        }

        private void buttonReward_Click(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItem != null)
            {
                WorkerData selectedWorker = (WorkerData)listBoxWorkers.SelectedItem;

                using (InputAmountForm popupForm = new InputAmountForm())
                {
                    if (popupForm.ShowDialog() == DialogResult.OK)
                    {
                        decimal amount = popupForm.Amount;
                        MessageBox.Show($"Поощрили на сумму: {amount.ToString()}");
                    }
                }
            }
        }

        private void buttonDeleteWorker_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция отключена!");
        }
    }
}
