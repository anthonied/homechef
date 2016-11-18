using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homechef.Domain
{
   public class Cart
    {
        public int Id { get; set; }
        public int Customer_id { get; set; }
        public int Chef_id { get; set; }
        public DateTime Orderdate { get; set; }
        public int Total { get; set; }
        public string Status { get; set; }
       
    }
}
