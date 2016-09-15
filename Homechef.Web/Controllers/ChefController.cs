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
            using (var chefRepo = new ChefRepository())
            {
                var model = chefRepo.GetByUser(User);
              return View(model);
            }

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
            
                    using (var chefRepo = new ChefRepository())
                   {
                         var chef = chefRepo.GetByUser(User);
                chefRepo.Create(model.ToDomain(),User);
                        return new JsonResult
                        {
                            Data = new {IsOk = true}
                        };
                    }
                
               
            
        }
    }
}