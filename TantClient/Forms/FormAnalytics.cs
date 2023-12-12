using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;
using TantClient.Models;
using TantClient.Services;

namespace TantClient.Forms
{
    public partial class FormAnalytics : Form
    {
        private readonly AnalyticService _analyticService;
        public FormAnalytics()
        {
            InitializeComponent();
            loadTheme();
            _analyticService = new AnalyticService();
            DateTime dateTimeNow = DateTime.Now;
            DateTime startOfMonth = new DateTime(dateTimeNow.Year, dateTimeNow.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            dateTimePickerTrafficFrom.Value = startOfMonth;
            dateTimePickerTrafficTo.Value = endOfMonth;
            dateTimePickerFrom.Value = startOfMonth;
            dateTimePickerTo.Value = endOfMonth;
            getWorkerLinkData(startOfMonth, endOfMonth);
            LoadChartData(startOfMonth, endOfMonth);
        }

        Dictionary<string, double> DisactiveByPercentWorkers = new Dictionary<string, double>();
        private void loadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.ForeColor = Color.WhiteSmoke;
                }
            }
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimePickerFrom.Value;
            DateTime dateTo = dateTimePickerTo.Value;
            getWorkerLinkData(dateFrom, dateTo);
        }
        private async void getWorkerLinkData(DateTime dateFrom, DateTime dateTo)
        {
            string[] workerLinkParts = textBoxWorkerLink.Text.Split('=');
            if (workerLinkParts[1].Length == 0)
            {
                MessageBox.Show("Вы не указали @username сотрудника!");
                return;
            }
            richTextBoxResult.Text = "Загрузка...";
            try
            {
                string response = await _analyticService.getWorkerConversion(textBoxWorkerLink.Text, dateFrom, dateTo);
                WorkerConversion workerConversion = JsonConvert.DeserializeObject<WorkerConversion>(response);

                richTextBoxResult.Text = richTextBoxResult.Text = "С " + dateFrom + "\n" +
                                "По " + dateTo + "\n" +
                                "По ссылке " + textBoxWorkerLink.Text + "\n\n" +
                                "Перешли по ссылке: " + workerConversion.all_transitions + " человек" + "\n" +
                                "Нажали на кнопку: " + workerConversion.button_transitions + " человек" + "\n" +
                                "Написали в личку: " + workerConversion.private_transitions + " человек" + "\n";
            }
            catch (Exception ex)
            {
                richTextBoxResult.Text = ex.Message;
            }
        }
        Dictionary<string, List<User>> WorkersData = new Dictionary<string, List<User>>();
        int totalUsers = 0;
        private async void LoadChartData(DateTime dateFrom, DateTime dateTo)
        {
            chart1.Annotations.Clear();
            WorkersData.Clear();
            totalUsers = 0;
            TextAnnotation LoadingAnnotation = new TextAnnotation();
            LoadingAnnotation.Text = "Загрузка...";
            LoadingAnnotation.X = 0;
            LoadingAnnotation.Y = 0;
            LoadingAnnotation.AnchorAlignment = ContentAlignment.MiddleCenter;
            LoadingAnnotation.Alignment = ContentAlignment.MiddleCenter;
            LoadingAnnotation.ForeColor = Color.FromArgb(41, 47, 51);
            LoadingAnnotation.Font = new Font("Microsoft YaHei", 12, FontStyle.Bold);
            chart1.Annotations.Add(LoadingAnnotation);
            try
            {
                string json = await _analyticService.getTotalChats(dateFrom, dateTo);
                if (json == null) {
                    return;
                }
                User[] UserData = JsonConvert.DeserializeObject<User[]>(json);
                foreach (var user in UserData)
                {
                    string workerName = user.worker.name;
                    if (WorkersData.ContainsKey(workerName))
                    {
                        WorkersData[workerName].Add(user);
                    }
                    else
                    {
                        WorkersData[workerName] = new List<User>
                        {
                            user
                        };
                    }
                    totalUsers++;
                }
                RenderData();
            }
            
            catch (ObjectDisposedException) {
                // При смене окна
            }

        }
        private void RenderData()
        {
            try
            {
                chart1.Series["SeriesWorkers"].Points.Clear();
                DisactiveByPercentWorkers.Clear();
                chart1.Annotations.Clear();
                foreach (var worker in WorkersData)
                {
                    int workerUsers = worker.Value.Count;
                    string workerName = worker.Key;
                    double percent = Math.Round(((double)workerUsers / totalUsers) * 100, 2);
                    if (percent < 5)
                    {
                        DisactiveByPercentWorkers.Add(workerName, percent);
                        continue;
                    }
                    int index = chart1.Series["SeriesWorkers"].Points.AddXY(worker.Key, workerUsers);
                    chart1.Series["SeriesWorkers"].Points[index].Tag = worker.Key;
                    chart1.Series["SeriesWorkers"].Points[index].Label = $"{percent}%";
                    chart1.Series["SeriesWorkers"].Points[index].LabelBackColor = Color.Transparent;
                    chart1.Series["SeriesWorkers"].Points[index].LabelForeColor = Color.White;
                    chart1.Series["SeriesWorkers"].Points[index].LegendText = workerName;
                }
                double DisactiveWorkersPercent = Math.Round(DisactiveByPercentWorkers.Sum(worker => worker.Value), 2);
                if (DisactiveWorkersPercent > 1.0)
                {
                    LegendItem LegendItemDisabledByPercent = new LegendItem();
                    string DisactiveWorkersName = $"Прочее (<5%) ({DisactiveWorkersPercent}%)";
                    int index = chart1.Series["SeriesWorkers"].Points.AddXY(DisactiveWorkersName, DisactiveWorkersPercent);
                    chart1.Series["SeriesWorkers"].Points[index].Tag = DisactiveWorkersName;
                    chart1.Series["SeriesWorkers"].Points[index].Label = $"{DisactiveWorkersPercent}%";
                    chart1.Series["SeriesWorkers"].Points[index].LabelBackColor = Color.Transparent;
                    chart1.Series["SeriesWorkers"].Points[index].LabelForeColor = Color.White;
                    chart1.Series["SeriesWorkers"].Points[index].LegendText = DisactiveWorkersName;
                }
                TextAnnotation annotation = new TextAnnotation
                {
                    Text = "Всего: " + totalUsers.ToString(),
                    X = 0,
                    Y = 0,
                    AnchorAlignment = ContentAlignment.MiddleCenter,
                    Alignment = ContentAlignment.MiddleCenter,
                    ForeColor = Color.FromArgb(41, 47, 51),
                    Font = new Font("Microsoft YaHei", 12, FontStyle.Bold)
                };
                chart1.Annotations.Add(annotation);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonTrafficGo_Click(object sender, EventArgs e)
        {
            if (dateTimePickerTrafficFrom.Value > DateTime.Now) {
                MessageBox.Show("Некорректно задан период");
            } else {
                LoadChartData(
                    dateTimePickerTrafficFrom.Value,
                    dateTimePickerTrafficTo.Value
                );
            }
        }
    }
}

