using System;
using Homechef.Domain;
namespace Homechef.Web.Models
{
    public class CartitemAddModel
    {
        public int Cart_id { get; set; }
        public int Menu_id { get; set; }
        public int Quantity { get; set; }
        public int Pricepp { get; set; }
        public int Subtotal { get; set; }
        public DateTime Lastupdated { get; set; }

        public Cartitem ToDomain()
        {
            return new Cartitem
            {
                Cart_id = Cart_id,
                Menu_id = Menu_id,
                Quantity = Quantity,
                Pricepp = Pricepp,
                Subtotal = Subtotal,
                Lastupdated = Lastupdated,
                
            };
        }


    }
}