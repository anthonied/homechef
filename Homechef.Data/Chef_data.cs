using System;
using Homechef.Domain;


namespace Homechef.Data
{
    public class Chef_data
    {
        public int chefid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public int mobile { get; set; }
        public string residentialaddress { get; set; }
        public string idnumber { get; set; }

        public static Chef_data FromDomain(Chef chef)
        {
            return new Chef_data
            {
                firstname = chef.Firstname,
                lastname = chef.Lastname,
                age = chef.Age,
                email = chef.Email,
                mobile = chef.Mobile,
                residentialaddress = chef.Residentialaddress,
                idnumber = chef.Idnumber,
            };

        }
    
    }

}
