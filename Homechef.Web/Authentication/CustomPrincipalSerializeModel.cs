using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Homechef.Domain;

namespace Homechef.Web.Authentication
{
    public class CustomPrincipalSerializeModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public static CustomPrincipalSerializeModel FromDomain(User user)
        {
            return new CustomPrincipalSerializeModel
            {
                Id = user.Id,
                UserName = user.Email,
                Password = user.Password
            };
        }
    }
}