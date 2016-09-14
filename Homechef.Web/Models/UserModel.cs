using System;
using Homechef.Domain;

namespace Homechef.Web.Models
{
    public class UserModel
    {
        
        public string Email { get; set; }
        public string Password { get; set; }
        public string Option { get; set; }

        public User ToDomain()
        {
            return new User
            {
                Email = Email,
                Password = Password,
                

            };
        }
    }
}