using System;
using Homechef.Domain;
using Microsoft.Owin.Security.Provider;

namespace Homechef.Web.Models
{
    public class CustomerUpdateRegistrationModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Idnumber { get; set; }
        public string Mobile { get; set; }
        //public string Email { get; set; }

        public Customer ToDomain()
        {
            return new Customer
            {
                Id = Id,
                Firstname = Firstname,
                Lastname = Lastname,
                Idnumber = Idnumber,
                Mobile = Mobile,

            }
            ;
        }
    }

}
