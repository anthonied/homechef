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
        public int Cart_id { get; set; }
        public int Menu_id { get; set; }
        public int Quantity { get; set; }
        public int Pricepp { get; set; }
        public int Subtotal { get; set; }
       public DateTime Lastupdated { get; set; }

    }
}
