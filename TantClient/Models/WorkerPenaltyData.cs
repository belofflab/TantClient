using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TantClient.Models
{
    public class WorkerPenaltyData
    {
        public long Worker { get; set; }
        public decimal Amount { get; set; }
        public bool IsAdmin { get; set; }
        public string Type { get; set; }

        public WorkerPenaltyData(long workerId, decimal amount, bool isAdmin, string type)
        {
            Worker = workerId;
            Amount = amount;
            IsAdmin = isAdmin;
            Type = type;
        }
    }
}
