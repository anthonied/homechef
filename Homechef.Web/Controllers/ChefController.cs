using System.Web.Mvc;
using Homechef.Repository.MsSql;
using Homechef.Web.Models;

namespace Homechef.Web.Controllers
{
    public class ChefController : BaseController
    {
        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Home()
        {
            using (var chefRepo = new ChefRepository())
            {
                var chef = chefRepo.GetByUserId(User.Id);
                var model = ChefModel.FromDomain(chef);
                return View(model);
            }
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