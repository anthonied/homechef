using System;
using Homechef.Domain;

namespace Homechef.Web.Models
{
    public class ResetPasswordModel
    {
        public string Email { get; set; }
        public string Newpassword { get; set; }

        public ResetPasswordModel ToDomain()
        {
            return new ResetPasswordModel
            {
                Email = Email,
                Newpassword = Newpassword,
            };

        }
        
    }
}