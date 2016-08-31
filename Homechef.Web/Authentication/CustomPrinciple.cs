using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Homechef.Domain;
using System.Security.Principal;

namespace Homechef.Web.Authentication
{
    public class CustomPrincipal : User, ICustomPrincipal
    {
        public IIdentity Identity { get; private set; }

        public bool IsInRole(string role)
        {

            return false;
        }

        public CustomPrincipal(string email)
        {
            Identity = new GenericIdentity(email);
        }
    }

    
}