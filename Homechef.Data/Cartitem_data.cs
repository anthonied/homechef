using System;
using Homechef.Domain;

namespace Homechef.Data
{
   public class Cartitem_data
    {
        public int id { get; set; }
        public int cart_id { get; set; }
        public int menu_id { get; set; }
        public int quantity { get; set; }
        public int unitprice { get; set; }
        public int totalprice { get; set; }

        public static Cartitem_data FromDomain(Cartitem cartitem)
        {
            return new Cartitem_data
            {
                id = cartitem.Id,
                cart_id = cartitem.Cartid,
                menu_id = cartitem.Menuid,
                quantity = cartitem.Quantity,
                unitprice = cartitem.Unitprice,
                totalprice = cartitem.Unitprice,

            };
        }
    }
}
