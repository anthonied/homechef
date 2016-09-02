using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Homechef.Domain;
using Homechef.Repository.MsSql;
using Homechef.Web.Models;
using System.Web.Mvc;


namespace Homechef.Web.Controllers
{
    public class MenuController:BaseController
    {
        public ActionResult Add()
        {
            return View();
        }

        public JsonResult Create (MenuModel model )
        {
            using (var repo = new MenuRepository())
            {
                repo.Create(model.ToDomain());
                return new JsonResult
                {
                    Data = new {IsOk = true}
                };
            }
        }
    }
}