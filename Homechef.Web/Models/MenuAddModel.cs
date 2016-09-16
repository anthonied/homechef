﻿using System;
using Homechef.Domain;

namespace Homechef.Web.Models
{
    public class MenuAddModel
    {
        public int Id { get; set; }
        public int Chef_Id { get; set; }
        public string Dishname { get; set; }
        public string Cuisinetype { get; set; }
        public string Dishcategory { get; set; }
        public int Pricepp { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string Dishimage { get; set; }
        public bool Takeaway { get; set; }
        public bool Dineinwithchef { get; set; }
        public bool Homedelivery { get; set; }
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
        public string Status { get; set; }

        public Menu ToDomain()
        {
            return new Menu
            {
                Chef_id = Chef_Id,
                Dishname = Dishname,
                Dishcategory = Dishcategory,
                Cuisinetype = Cuisinetype,
                Pricepp = Pricepp,
                Currency = Currency,
                Description = Description,
                Dishimage = Dishimage,
                CanOrderAsTakeaway = Takeaway,
                CanOrderAsDineinwithchef = Dineinwithchef,
                CanOrderAsHomedelivery = Homedelivery,
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

        public static MenuAddModel FromDomain(Menu menu)
        {
            return new MenuAddModel
            {
                Chef_Id =  menu.Chef_id,
                Dishname = menu.Dishname,
                Dishcategory = menu.Dishcategory,
                Cuisinetype = menu.Cuisinetype,
                Pricepp = menu.Pricepp,
                Currency = menu.Currency,
                Description = menu.Description,
                Dishimage = menu.Dishimage,
                Takeaway = menu.CanOrderAsTakeaway,
                Dineinwithchef = menu.CanOrderAsDineinwithchef,
                Homedelivery = menu.CanOrderAsHomedelivery,
                Availabilitytype = menu.Availabilitytype,
                Availableonmonday = menu.Availableonmonday,
                Availableontuesday = menu.Availableontuesday,
                Availableonwednesday = menu.Availableonwednesday,
                Availableonthursday = menu.Availableonthursday,
                Availableonfriday = menu.Availableonfriday,
                Availableonsaturday = menu.Availableonsaturday,
                Availableonsunday = menu.Availableonsunday,
                Orderminimum = menu.Orderminimum,
                Ordermaximum = menu.Ordermaximum,
                Leadtime = menu.Leadtime,
            };

        }
    }
}