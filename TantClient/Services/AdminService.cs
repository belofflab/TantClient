using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TantClient.Services
{
    internal class AdminService : HttpClientService
    {
        public async Task<string> getPaymentDetails()
        {
            string response = await GetAsync("/admin/payment/details/");
            if (response == null)
            {
                MessageBox.Show("Произошла ошибка...");
            }
            return response;
        }
        public async Task<string> getProjectInfo()
        {
            string response = await GetAsync("/admin/info/");
            if (response == null)
            {
                MessageBox.Show("Произошла ошибка...");
            }
            return response;
        }
    }
}
