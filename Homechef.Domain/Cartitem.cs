using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homechef.Domain
{
   public class Cartitem
    {
        public int Id { get; set; }
        public int Cartid { get; set; }
        public int Menuid { get; set; }
        public int Quantity { get; set; }
        public int Unitprice { get; set; }
        public int Totalprice { get; set; }

    }
}
