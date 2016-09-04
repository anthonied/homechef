using System;
using Homechef.Domain;

namespace Homechef.Web.Models
{
    public class MenuModel
    {
        public int Id { get; set; }
        public int Chefid { get; set; }
        public string Dishname { get; set; }
        public string Cuisinetype { get; set; }
        public string Dishcategory { get; set; }
        public int Pricepp { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string Dishimage { get; set; }
        public string Takeaway { get; set; }
        public string Dineinwithchef { get; set; }
        public string Homedelivery { get; set; }
        public string Availabilitytype { get; set; }
        public string Availableonmonday { get; set; }
        public string Availableontuesday { get; set; }
        public string Availableonwednesday { get; set; }
        public string Availableonthursday { get; set; }
        public string Availableonfriday { get; set; }
        public string Availableonsaturday { get; set; }
        public string Availableonsunday { get; set; }
        public int Orderminimum { get; set; }
        public int Ordermaximum { get; set; }
        public int Leadtime { get; set; }

        public Menu ToDomain()
        {
            return new Menu
            {
                Chefid = Chefid,
                Dishname = Dishname,
                Dishcategory =Dishcategory,
                Cuisinetype = Cuisinetype,
                Pricepp = Pricepp,
                Currency = Currency,
                Description = Description,
                Dishimage = Dishimage,
                Takeaway = Takeaway,
                Dineinwithchef = Dineinwithchef,
                Homedelivery = Homedelivery,
                Availabilitytype = Availabilitytype,
               Availableonmonday = Availableonmonday,
               Availableontuesday = Availableontuesday,
               Availableonwednesday = Availableonwednesday,
               Availableonthursday = Availableonthursday,
               Availableonfriday = Availableonfriday,
               Availableonsaturday = Availableonsaturday,
               Availableonsunday = Availableonsunday,
                Orderminimum = Orderminimum,
                Ordermaximum = Ordermaximum,
                Leadtime = Leadtime,

            };
        }

    }
}