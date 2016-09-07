using Homechef.Repository.MsSql;
using Homechef.Web.Models;
using System.Web.Mvc;


namespace Homechef.Web.Controllers
{
    public class MenuController:BaseController
    {
        public ActionResult Add()
        {
            using (var chefRepo = new ChefRepository())
            {
                var chef = chefRepo.GetByUserId(User.Id);

                return View(chef.Id);
            }
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