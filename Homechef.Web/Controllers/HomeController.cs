using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homechef.Repository.MsSql;

namespace Homechef.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Home()
        {
            using (var chefRepo = new ChefRepository())
            {
                var chef = chefRepo.GetByUserId(User.Id);

                return View(chef);
            }
        }
    }
}