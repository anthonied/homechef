using System;
using System.Linq;
using System.Web.Mvc;
using Homechef.Domain;
using Homechef.Repository.MsSql;
using Homechef.Web.Models;

namespace Homechef.Web.Controllers
{
    public class CartController : BaseController
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Add(CartModel model)
        {
            using (var cartrepo = new CartRepository())
            using (var cartitemrepo = new CartitemRepository())
            {
                model.CartAdd.CustomerId = User.Id;
                int cartid = cartrepo.Create(model.CartAdd.ToDomain());

                foreach (var items in model.CartItems)
                {
                    items.Cart_id = cartid;
                    cartitemrepo.Create(items.ToDomain());
                }
               
              return new JsonResult
                {
                    Data = new { IsOk = true }
                };
            }
        }
    }
}