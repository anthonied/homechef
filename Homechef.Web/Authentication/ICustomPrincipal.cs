using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Homechef.Web.Authentication
{
    public interface ICustomPrincipal : IPrincipal
    {
        int Id { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}