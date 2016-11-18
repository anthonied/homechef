using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homechef.Web.Models
{
    public class CartModel
    {
        public CartAddModel CartAdd { get; set; }
        public List<CartitemAddModel> CartItems { get; set; }
    }
}