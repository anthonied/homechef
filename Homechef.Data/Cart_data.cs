using System;
using Homechef.Domain;
namespace Homechef.Data
{
    public class Cart_data
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public int chef_id { get; set; }
       

        public static Cart_data FromDomain(Cart cart)
        {
            return new Cart_data
            {
                id = cart.Id,
                customer_id = cart.Customerid,
                chef_id = cart.Chefid,
               

            };

        }
    }
}
