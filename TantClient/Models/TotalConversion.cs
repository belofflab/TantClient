using System.Collections.Generic;


namespace TantClient.Models
{
    public class TotalConversion
    {
        public double total { get; set; }
        public double marginal { get; set; }
        public double total_requests { get; set; }
        public Dictionary<string, WorkerReceiptDetail> workers { get; set; }
    }
}
