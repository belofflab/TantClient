using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;
using TantClient.Models;
using TantClient.Services;

namespace TantClient.Forms
{
    public partial class FormCashTurnover : Form
    {
        private TotalConversion totalConversion;
        private readonly AnalyticService _analyticService;
        public FormCashTurnover()
        {
            InitializeComponent();
            DateTime dateTimeNow = DateTime.Now;
            DateTime startOfMonth = new DateTime(dateTimeNow.Year, dateTimeNow.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            _analyticService = new AnalyticService();
            getCashTurnover(startOfMonth, endOfMonth);
        }

        private async void getCashTurnover(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            try {
                totalConversion = null;
                richTextBoxCashTurnover.Clear();
                richTextBoxCashTurnover.Text = "Загрузка...";
                string response = await _analyticService.getTotalConversion(dateTimeFrom, dateTimeTo);
                richTextBoxCashTurnover.Clear();
                totalConversion = JsonConvert.DeserializeObject<TotalConversion>(response);
                richTextBoxCashTurnover.AppendText($"Приход: {totalConversion.total}₽\n");
                richTextBoxCashTurnover.AppendText($"Маржа: {totalConversion.marginal}₽\n");
                richTextBoxCashTurnover.AppendText($"Кол-во чеков: {totalConversion.total_requests}\n\n");

                foreach (var workerData in totalConversion.workers)
                {
                    richTextBoxCashTurnover.AppendText($"{workerData.Key} ({workerData.Value.len}Ч) {workerData.Value.sum}₽ (~{workerData.Value.avg}₽)\n");
                }
            } catch (ObjectDisposedException)
            {
                // При смене формы 
            }

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