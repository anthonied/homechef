using System.Web.Mvc;

namespace Homechef.Web.Controllers
{
    public class CustomerController:  BaseController
    {
       public ActionResult Home()
        {
           return View();
      }
    }
}