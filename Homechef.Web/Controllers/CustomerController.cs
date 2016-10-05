using System.Linq;
using System.Web.Mvc;
using Homechef.Domain;
using Homechef.Repository.MsSql;
using Homechef.Web.Models;

namespace Homechef.Web.Controllers
{
    public class CustomerController:  BaseController
    {
        public ActionResult Home()
        {
            using (var customerRepo = new CustomerRepository())
            using (var menurepo = new MenuRepository())
            {
                var model = new CustomerHomeModel();
                var customer = customerRepo.GetByUser(User);
                model.Customer = CustomerModel.FromDomain(customer);

                var menus = menurepo.GetAllActiveMenu();
                model.Menus = menus.Select(MenuDisplayModel.FromDomain).ToList();
                return View(model);
            }
        }

        public ActionResult UpdateRegistration()
        {
            using (var customerRepo = new CustomerRepository())
            {
                var model = customerRepo.GetByUser(User);
                return View(model);
            }

        }

        public JsonResult Update(CustomerUpdateRegistrationModel updatemodel)
        {

            using (var customerRepo = new CustomerRepository())
            {
                customerRepo.Update(updatemodel.ToDomain());
                return new JsonResult
                {
                    Data = new { IsOk = true }
                };
            }



        }
    }

}