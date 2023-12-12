using System;
using System.Collections.Generic;

namespace TantClient.Models
{
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
        public Worker worker { get; set; }
    }
}
