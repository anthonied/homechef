using System;
using System.Collections.Generic;
using System.Linq;
using System;
using Homechef.Domain;

namespace Homechef.Web.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Fullname
        {
            get { return string.Format("{0} {1}", Firstname, Lastname); }
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Idnumber { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public static CustomerModel FromDomain(Customer customer)
        {
            return new CustomerModel
            {
                Firstname = customer.Firstname,
                Lastname = customer.Lastname,
                Idnumber = customer.Idnumber,
                Mobile = customer.Mobile,
                Email = customer.Email,
            };

        }

    }
}