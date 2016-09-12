using System;
using System.Runtime.Remoting.Messaging;
using Homechef.Domain;

namespace Homechef.Data
{
    public class Menu_data
    {
        public int id { get; set; }
        public int chefid { get; set; }
        public string dishname { get; set; }
        public string dishcategory { get; set; }
        public string cuisinetype { get; set; }
        public int pricepp { get; set; }
        public string currency { get; set; }
        public string description { get; set; }
        public string dishimage { get; set; }
        public bool takeaway { get; set; }
        public bool dineinwithchef { get; set; }
        public bool homedelivery { get; set; }
        public string availabilitytype { get; set; }
        public string availableonmonday { get; set; }
        public string availableontuesday { get; set; }
        public string availableonwednesday { get; set; }
        public string availableonthursday { get; set; }
        public string availableonfriday { get; set; }
        public string availableonsaturday { get; set; }
        public string availableonsunday { get; set; }
        public int orderminimum { get; set; }
        public int ordermaximum { get; set; }
        public int leadtime { get; set; }
        public string status { get; set; }

        public static Menu_data FromDomain(Menu menu)
        {

            return new Menu_data
            {
              
                chefid =menu.Chefid,
                dishname =menu.Dishname,
                dishcategory = menu.Dishcategory,
                cuisinetype =menu.Cuisinetype,
                pricepp =menu.Pricepp,
                currency =menu.Currency,
                description =menu.Description,
                dishimage =menu.Dishimage,
                takeaway = menu.CanOrderAsTakeaway,
                dineinwithchef = menu.CanOrderAsDineinwithchef,
                homedelivery = menu.CanOrderAsHomedelivery,
                availabilitytype = menu.Availabilitytype,
                availableonmonday = menu.Availableonmonday,
                availableontuesday = menu.Availableontuesday,
                availableonwednesday = menu.Availableonwednesday,
                availableonthursday = menu.Availableonthursday,
                availableonfriday = menu.Availableonfriday,
                availableonsaturday = menu.Availableonsaturday,
                availableonsunday = menu.Availableonsunday,
                orderminimum =menu.Orderminimum,
                ordermaximum =menu.Ordermaximum,
                leadtime =menu.Leadtime,
                status = menu.Status,
             };
        }
    }
}
