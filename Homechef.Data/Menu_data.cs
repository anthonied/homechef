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
        public string cuisinetype { get; set; }
        public int pricepp { get; set; }
        public int currency { get; set; }
        public string description { get; set; }
        public string dishimage { get; set; }
        public string deliveryoption { get; set; }
        public string availabilitytype { get; set; }
        public string deliverydays { get; set; }
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
                deliveryoption =menu.Deliveryoption,
                availabilitytype = menu.Availabilitytype,
                deliverydays =menu.Deliverydays,
                orderminimum =menu.Orderminimum,
                ordermaximum =menu.Ordermaximum,
                leadtime =menu.Leadtime,
             };
        }
    }
}
