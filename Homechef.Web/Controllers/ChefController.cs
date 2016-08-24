using System;

using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homechef.Domain;
using Homechef.Repository.MsSql;
using Homechef.Web.Models;

namespace Homechef.Web.Controllers
{
    public class ChefController : Controller
    {
        // GET: Chef
        public ActionResult Registration()
        {
            return View();
        }
        public JsonResult Create(ChefModel model)
        {
            var repo = new ChefRepository();
            repo.Create(model.ToDomain());
            return new JsonResult
            {
                Data = new { IsOk = true }
            };
        }
    }
}