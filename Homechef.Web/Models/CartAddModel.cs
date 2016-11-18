using System;
using Homechef.Domain;

namespace Homechef.Web.Models
{
    public class CartAddModel
    {
       
        public int CustomerId { get; set; }
        public int ChefId { get; set; }
        public int Total { get; set; }
        public string Status { get; set; }


        public Cart ToDomain()
        {
            return new Cart
            {
              
                Customer_id = CustomerId,
                Chef_id = ChefId,
                Total = Total,
                Status = Status,
               
               

            };



        }
    }
}