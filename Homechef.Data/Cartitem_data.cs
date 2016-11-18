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
        public int pricepp { get; set; }
        public int subtotal { get; set; }
        public DateTime lastupdated { get; set; }

        public static Cartitem_data FromDomain(Cartitem cartitem)
        {
            return new Cartitem_data
            {
                id = cartitem.Id,
                cart_id = cartitem.Cart_id,
                menu_id = cartitem.Menu_id,
                quantity = cartitem.Quantity,
                pricepp = cartitem.Pricepp,
                subtotal= cartitem.Subtotal,
                lastupdated = cartitem.Lastupdated,

            };
        }
    }
}
