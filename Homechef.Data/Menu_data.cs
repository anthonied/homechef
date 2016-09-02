﻿using System;
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
        public int currency { get; set; }
        public string description { get; set; }
        public string dishimage { get; set; }
        public string takeaway { get; set; }
        public string dineinwithchef { get; set; }
        public string homedelivery { get; set; }
        public string availabilitytype { get; set; }
        public string availableonmonday { get; set; }
        public string availableontuesday { get; set; }
        public string availableonwedday { get; set; }
        public string availableonthursday { get; set; }
        public string availableonfriday { get; set; }
        public string availableonsaturday { get; set; }
        public string availableonsunday { get; set; }
        public int orderminimum { get; set; }
        public int ordermaximum { get; set; }
        public int leadtime { get; set; }

        public static Menu_data FromDomain(Menu menu)
        {

            return new Menu_data
            {
              
                chefid =menu.Chefid,
                dishname =menu.Dishname,
                cuisinetype =menu.Cuisinetype,
                pricepp =menu.Pricepp,
                currency =menu.Currency,
                description =menu.Description,
                dishimage =menu.Dishimage,
                takeaway = menu.Takeaway,
                dineinwithchef = menu.Dineinwithchef,
                homedelivery = menu.Homedelivery,
                availabilitytype = menu.Availabilitytype,
                availableonmonday = menu.Availableonmonday,
                availableontuesday = menu.Availableontuesday,
                availableonwedday = menu.Availableonwednesday,
                availableonthursday = menu.Availableonthursday,
                availableonfriday = menu.Availableonfriday,
                availableonsaturday = menu.Availableonsaturday,
                availableonsunday = menu.Availableonsunday,
                orderminimum =menu.Orderminimum,
                ordermaximum =menu.Ordermaximum,
                leadtime =menu.Leadtime,
             };
        }
    }
}
