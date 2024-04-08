using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class CustomerBO
    {
        public int customer_id { get; set; }
        public string cust_name { get; set; }
        public string city { get; set; }
        public int grade { get; set; }
        public int salesman_id { get; set; }
    }
}
