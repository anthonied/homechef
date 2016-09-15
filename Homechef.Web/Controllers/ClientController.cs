using System.Web.Mvc;

namespace Homechef.Web.Controllers
{
    public class ClientController:  BaseController
    {
       public ActionResult Home()
        {
           return View();
      }
    }
}