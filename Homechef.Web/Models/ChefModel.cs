using System;
using Homechef.Domain;

namespace Homechef.Web.Models
{
    public class ChefModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public string Residentialaddress { get; set; }
        public string Idnumber { get; set; }

        public Chef ToDomain()
        {

            return new Chef
            {
                Firstname = Firstname,
                Lastname = Lastname,
                Age = Age,
                Email = Email,
                Mobile = Mobile,
                Residentialaddress = Residentialaddress,
                Idnumber = Idnumber,
            };
        }
    }
}