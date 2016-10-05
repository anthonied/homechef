using System;
using Homechef.Domain;


namespace Homechef.Data
{
    public class Chef_data
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string idnumber { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string mobile { get; set; }
        public string streetname { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public int postalcode { get; set; }
        public string country { get; set; }
        public string chefpicture { get; set; }
        public string description { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string completeregistration { get; set; }


        public static Chef_data FromDomain(Chef chef)
        {
            return new Chef_data
            {   id =chef.Id,
                firstname = chef.Firstname,
                lastname = chef.Lastname,
                idnumber = chef.Idnumber,
                age = chef.Age,
                sex = chef.Sex,
                mobile = chef.Mobile,
                streetname = chef.Streetname,
                suburb = chef.Suburb,
                city = chef.City,
                province = chef.Province,
                postalcode = chef.Postalcode,
                country = chef.Country,
                chefpicture = chef.Chefpicture,
                description = chef.Description,
                email = chef.Email,
                completeregistration = chef.Completeregistration
            };
        }



        public Chef ToDomain()
        {
            return new Chef
            {
                Id = id,
                Firstname = firstname,
                Lastname = lastname,
                Idnumber = idnumber,
                Age = age,
                Sex = sex,
                Mobile = mobile,
                Streetname = streetname,
                Suburb = suburb,
                City = city,
                Province = province,
                Postalcode = postalcode,
                Country = country,
                Chefpicture = chefpicture,
                Description = description,
                Completeregistration = completeregistration



            };
        }
    }
}

