using System;
using Homechef.Domain;

namespace Homechef.Web.Models
{
    public class ChefModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Idnumber { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public int Mobile { get; set; }
        public string Streetname { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int Postalcode { get; set; }
        public string Country { get; set; }
        public string Chefpicture { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Chef ToDomain()
        {

            return new Chef
            {
                Firstname = Firstname,
                Lastname=Lastname,
                Idnumber=Idnumber,
                Age=Age,
                Sex=Sex,
                Mobile=Mobile,
                Streetname=Streetname,
                Suburb=Suburb,
                City=City,
                Province=Province,
                Postalcode=Postalcode,
                Country=Country,
                Chefpicture=Chefpicture,
                Description=Description,
                Email = Email,
                Password = Password,
                
            };
        }
    }
}