using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TantClient.Forms
{
    public partial class FormCashTurnover : Form
    {
        private TotalConversion totalConversion;
        public FormCashTurnover()
        {
            InitializeComponent();
            DateTime dateTimeNow = DateTime.Now;
            DateTime startOfMonth = new DateTime(dateTimeNow.Year, dateTimeNow.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            getCashTurnover(startOfMonth, endOfMonth);
        }

        public class WorkerData
        {
            public double sum { get; set; }
            public double avg { get; set; }
            public int len { get; set; }
        }
        public class TotalConversion
        {
            public double total { get; set; }
            public double marginal { get; set; }
            public double total_requests { get; set; }
            public Dictionary<string, WorkerData> workers { get; set; }

        }

        private async void getCashTurnover(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            totalConversion = null;
            richTextBoxCashTurnover.Clear();
            richTextBoxCashTurnover.Text = "Загрузка...";
            HttpClient client = new HttpClient();
            try {
                string response = await client.GetStringAsync($"https://tant.belofflab.com/api/v1/analytics/total/conversion?date_range={dateTimeFrom.ToString("dd.MM.yyyy")} {dateTimeTo.ToString("dd.MM.yyyy")}");
                richTextBoxCashTurnover.Clear();
                totalConversion = JsonConvert.DeserializeObject<TotalConversion>(response);
                richTextBoxCashTurnover.AppendText($"Приход: {totalConversion.total}₽\n");
                richTextBoxCashTurnover.AppendText($"Маржа: {totalConversion.marginal}₽\n");
                richTextBoxCashTurnover.AppendText($"Кол-во чеков: {totalConversion.total_requests}\n\n");

                foreach (var workerData in totalConversion.workers)
                {
                    richTextBoxCashTurnover.AppendText($"{workerData.Key} ({workerData.Value.len}Ч) {workerData.Value.sum}₽ (~{workerData.Value.avg}₽)\n");
                }
            } catch (Exception){}
        }

        private void btnApplyCashTurnoverFilters_Click(object sender, EventArgs e)
        {
            if (dateTimePickerCashTurnoverFrom.Value > DateTime.Now)
            {
                MessageBox.Show("Некорректно задана дата!");
                return;
            }
            getCashTurnover(dateTimePickerCashTurnoverFrom.Value, dateTimePickerCashTurnoverTo.Value);
        }
    }
}