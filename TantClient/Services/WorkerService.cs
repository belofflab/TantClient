using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TantClient.Models;

namespace TantClient.Services
{
    internal class WorkerService : HttpClientService
    {
        public async Task<string> getWorkers()
        {
            string response = await GetAsync("/workers/");
            if (response == null)
            {
                MessageBox.Show("Сотрудники не были найдены...");
            }
            return response;
        }
        public async Task<string> Reward(WorkerRewardData workerRewardData)
        {
            string response = await PostAsync("/admin/reward/", JsonConvert.SerializeObject(workerRewardData));
            if (response == null)
            {
                MessageBox.Show("Не удалось выдать премию сотруднику");
            } 
            return response;
        }
        public async Task<string> Penalty(WorkerPenaltyData workerPenaltyData)
        {
            string response = await PostAsync("/admin/penalty/", JsonConvert.SerializeObject(workerPenaltyData));
            if (response == null)
            {
                MessageBox.Show("Не удалось выдать штраф сотруднику");
            }
            return response;
        }
        public async Task<string> Delete(long workerId)
        {
            string response = await PostAsync($"/workers/disable/{workerId}", "");
            if (response == null)
            {
                MessageBox.Show("Не удалось удалить сотрудника");
            }
            return response;
        }
    }
}
