using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TantClient.Services
{
    public class AnalyticService : HttpClientService
    {
        public async Task<string> getTotalConversion(DateTime dateFrom, DateTime dateTo)
        {
            string response = await GetAsync($"/analytics/total/conversion?date_range={dateFrom.ToString("dd.MM.yyyy")} {dateTo.ToString("dd.MM.yyyy")}");
            if (response == null)
            {
                MessageBox.Show("Произошла ошибка...");
            }
            return response;
        }
        public async Task<string> getWorkerConversion(string link, DateTime dateFrom, DateTime dateTo)
        {
            string response = await GetAsync($"/analytics/workers/conversion?link={link}&date_range={dateFrom.ToString("yyyy-MM-dd")} {dateTo.ToString("yyyy-MM-dd")}");
            if (response == null)
            {
                MessageBox.Show("Произошла ошибка...");
            }
            return response;
        }
        public async Task<string> getTotalChats(DateTime dateFrom, DateTime dateTo)
        {
            string response = await GetAsync($"/analytics/chats/total/?date_range={dateFrom.ToString("yyyy-MM-dd")} {dateTo.ToString("yyyy-MM-dd")}");
            if (response == null)
            {
                MessageBox.Show("Произошла ошибка...");
            }
            return response;
        }
    }
}
