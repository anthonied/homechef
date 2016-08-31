using System;
using Homechef.Domain;

namespace Homechef.Data
{
   public class User_data
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User ToDomain()
        {
            return new User
            {
                Email = email,
                Password = password,
                Id = id
            };
        }
        public static User_data FromDomain(User user)
        {
            return new User_data
            {
                email = user.Email,
                password = user.Password,

            };
        }
    }
}
