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
        public ActionResult UpdateRegistration()
        {
            using (var chefRepo = new ChefRepository())
            {
                var model = chefRepo.GetByUser(User);
              return View(model);
            }

        }
        public JsonResult Update(ChefUpdateRegistrationModel updatemodel)
        {

           using (var chefRepo = new ChefRepository())
            {
               chefRepo.Update(updatemodel.ToDomain());
                return new JsonResult
                {
                    Data = new { IsOk = true }
                };
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

            using (var userRepo1 = new UserRepository())
            {
                var user = userRepo1.CheckEmail(model.Email);

                if (user == null)
                {
                    using (var chefRepo = new ChefRepository())
                    using (var userRepo = new UserRepository())

                    {
                        userRepo.Create(new User { Email = model.Email, Password = model.Password });
                        chefRepo.Create(model.ToDomain());
                        return new JsonResult
                        {
                            Data = new { IsOk = true }
                        };
                    }
                }
                else
                {
                    {
                        return Json(false);
                    }
                }
            }
        }
    }
}