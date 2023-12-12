using System;
using System.Collections.Generic;

namespace TantClient.Models
{
    public class Worker
    {
        public long id { get; set; }
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
}
