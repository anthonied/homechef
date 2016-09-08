using System.Linq;
using System.Web.Mvc;
using Homechef.Domain;
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
            using (var menurepo = new MenuRepository())
            {
                var model = new ChefHomeModel();
                var chef = chefRepo.GetByUser(User);
                model.Chef = ChefModel.FromDomain(chef);

                var menus = menurepo.GetManyMenubyUserId(User.Id);
                model.Menus = menus.Select(MenuDisplayModel.FromDomain).ToList();
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