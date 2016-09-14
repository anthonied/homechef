using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Homechef.Web.Models;
using Homechef.Domain;
using Homechef.Web.Authentication;
using System.Web.Script.Serialization;
using System.Web.Security;
using Homechef.Repository.MsSql;

namespace Homechef.Web.Controllers
{

    public class AccountController : BaseController
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult ResetPassword()
        {
            return View();
        }
        public JsonResult ChangePassword(ResetPasswordModel model)
        {
            using (var userRepo = new UserRepository())
            {
                userRepo.ResetUserPassword(new User { Email = model.Email, Password = model.Newpassword });
                return new JsonResult
                {
                    Data = new { IsOk = true }
                };
            }
            
        }

        public JsonResult AttemptLogin(LoginModel model)
        {
            using (var userRepo = new UserRepository())
            {
                var user = userRepo.GetByEmail(model.Email);

                if (user == null || string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Password) ||
                    user.Password != model.Password) return Json(false);

                var serializeModel = CustomPrincipalSerializeModel.FromDomain(user);
                var serializer = new JavaScriptSerializer();

                var userData = serializer.Serialize(serializeModel);

                var authTicket = new FormsAuthenticationTicket(
                    1,
                    model.Email,
                    DateTime.Now,
                    DateTime.Now.AddMinutes(15),
                    false,
                    userData);

                var encTicket = FormsAuthentication.Encrypt(authTicket);
                var faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                Response.Cookies.Add(faCookie);

                return Json(true);
            }
        }
    }
}