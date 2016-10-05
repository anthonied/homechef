using System;
using Homechef.Domain;
namespace Homechef.Data
{
    public class Customer_data
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string idnumber { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string completeregistration { get; set; }


        public static Customer_data FromDomain(Customer customer)
        {
            return new Customer_data
            {
                id = customer.Id,
                firstname = customer.Firstname,
                lastname = customer.Lastname,
                idnumber = customer.Idnumber,
                mobile = customer.Mobile,
                email = customer.Email
            };
        }

        //public Customer ToDomain()
        //{
        //    return new Customer
        //    {
        //        Id = id,
        //        Firstname =firstname,
        //        Lastname = lastname,
        //        Idnumber = idnumber,
        //        Mobile = mobile,

        //    };
        //}
    }
}
