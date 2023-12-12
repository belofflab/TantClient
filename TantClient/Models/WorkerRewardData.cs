using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TantClient.TantClient;

namespace TantClient.Models
{
    public class WorkerRewardData
    {
        public long Worker { get; set; }
        public decimal Amount { get; set; }
        public bool IsAdmin { get; set; }
        public string Type { get; set; }
        public WorkerRewardData(long workerId, decimal amount, bool isAdmin, string type)
        {
            Worker = workerId;
            Amount = amount;
            IsAdmin = isAdmin;
            Type = type;
        }
    }

}
