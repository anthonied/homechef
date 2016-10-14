using System.Linq;
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
                var chef = chefRepo.GetByUser(User);

                return View(chef.Id);
            }
        }

        public JsonResult Create (MenuAddModel addModel )
        {
            using (var repo = new MenuRepository())
            {
                repo.Create(addModel.ToDomain());
                return new JsonResult
                {
                    Data = new {IsOk = true}
                };
            }
        }
        public JsonResult ChangeStatus(MenuStatusUpdateModel menustatusupdateModel)
        {
            using (var repo = new MenuRepository())
            {
                repo.ChangeStatusbyMenuId(menustatusupdateModel.ToDomain().Id);
                return new JsonResult
                {
                    Data = new { IsOk = true }
                };
            }
        }
        //public JsonResult ChefMenu(ChefModel chefmodel)
        //{
        //    using (var repo = new MenuRepository())
        //    {
        //        repo.ActiveMenubyChefId(chefmodel.ToDomain().Id);
        //        return new JsonResult
        //        {
        //            Data = new { IsOk = true }
        //        };
        //    }
        //}
        public ActionResult List(int id)
        {
                        
            using (var chefRepo = new ChefRepository())
            using (var menurepo = new MenuRepository())
            {
                var model = new MenuListModel();
                var chef = chefRepo.GetBychefId(id);
                model.Chef = ChefModel.FromDomain(chef);

                var menus = menurepo.ActiveMenubyChefId(id);
                model.Menus = menus.Select(MenuDisplayModel.FromDomain).ToList();
                return View(model);
            }


        }
    }
}