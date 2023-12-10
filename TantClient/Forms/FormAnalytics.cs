using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;
using System.Security.Policy;

namespace TantClient.Forms
{
    public partial class FormAnalytics : Form
    {
        public FormAnalytics()
        {
            InitializeComponent();
            loadTheme();
            DateTime dateTimeNow = DateTime.Now;
            DateTime startOfMonth = new DateTime(dateTimeNow.Year, dateTimeNow.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            dateTimePickerTrafficFrom.Value = startOfMonth;
            dateTimePickerTrafficTo.Value = endOfMonth;
            dateTimePickerFrom.Value = startOfMonth;
            dateTimePickerTo.Value = endOfMonth;
            getWorkerLinkData(startOfMonth, endOfMonth);
            LoadChartData(startOfMonth.ToString("yyyy-MM-dd"), endOfMonth.ToString("yyyy-MM-dd"));
        }

        public class Proxy
        {
            public int id { get; set; }
        }

        public class User
        {
            public object id { get; set; }
            public string username { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public bool is_free_consulting { get; set; }
            public bool is_processing { get; set; }
            public DateTime last_activity { get; set; }
            public DateTime first_touch { get; set; }
            public List<object> userpaymentdetails { get; set; }
            public List<object> matrixuserrequests { get; set; }
            public List<object> receiver { get; set; }
            public List<object> sender { get; set; }
            public WorkerData worker { get; set; }
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

        List<string> DisabledWorkers = new List<string>();
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
        public class WorkerConversion
        {
            public int all_transitions { get; set; }
            public int button_transitions { get; set; }
            public int private_transitions { get; set; }
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimePickerFrom.Value;
            DateTime dateTo = dateTimePickerTo.Value;
            getWorkerLinkData(dateFrom, dateTo);
        }
        private async void getWorkerLinkData(DateTime dateFrom, DateTime dateTo)
        {
            const string URL = "https://tant.belofflab.com/api/v1/analytics/workers/conversion";
            string[] workerLinkParts = textBoxWorkerLink.Text.Split('=');
            if (workerLinkParts[1].Length == 0)
            {
                MessageBox.Show("Вы не указали @username сотрудника!");
                return;
            }
            richTextBoxResult.Text = "Загрузка...";


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string urlParameters = $"?link={textBoxWorkerLink.Text}&date_range={dateFrom.ToString("yyyy-MM-dd")} {dateTo.ToString("yyyy-MM-dd")}";
            try
            {
                string response = await client.GetStringAsync(urlParameters);
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
        private async void LoadChartData(string dateTimeFrom, string dateTimeTo)
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
                string apiUrl = $"https://tant.belofflab.com/api/v1/analytics/chats/total/?date_range={dateTimeFrom} {dateTimeTo}";

                HttpClient client = new HttpClient();
                
                string json = await client.GetStringAsync(apiUrl);
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
                renderData();
            }
            
            catch (Exception){}
        }
        private void renderData()
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
            TextAnnotation annotation = new TextAnnotation();
            annotation.Text = "Всего: " + totalUsers.ToString();
            annotation.X = 0;
            annotation.Y = 0;
            annotation.AnchorAlignment = ContentAlignment.MiddleCenter;
            annotation.Alignment = ContentAlignment.MiddleCenter;
            annotation.ForeColor = Color.FromArgb(41, 47, 51);
            annotation.Font = new Font("Microsoft YaHei", 12, FontStyle.Bold);
            chart1.Annotations.Add(annotation);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTrafficGo_Click(object sender, EventArgs e)
        {
            if (dateTimePickerTrafficFrom.Value > DateTime.Now) {
                MessageBox.Show("Некорректно задан период");
                return;
            } else {
                buttonTrafficGo.Enabled = false;
                buttonTrafficGo.Text = "Загрузка...";
                LoadChartData(
                    dateTimePickerTrafficFrom.Value.ToString("yyyy-MM-dd"),
                    dateTimePickerTrafficTo.Value.ToString("yyyy-MM-dd")
                );
                buttonTrafficGo.Text = ">";
                buttonTrafficGo.Enabled = true;
            }
        }
    }
}

