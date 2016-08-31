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
        public int Pricepp { get; set; }
        public int Currency { get; set; }
        public string Description { get; set; }
        public string Dishimage { get; set; }
        public string Deliveryoption { get; set; }
        public string Availabilitytype { get; set; }
        public string Deliverydays { get; set; }
        public int Orderminimum { get; set; }
        public int Ordermaximum { get; set; }
        public int Leadtime { get; set; }

        public Menu ToDomain()
        {
            return new Menu
            {
                Chefid = Chefid,
                Dishname = Dishname,
                Cuisinetype = Cuisinetype,
                Pricepp = Pricepp,
                Currency = Currency,
                Description = Description,
                Dishimage = Dishimage,
                Deliveryoption = Deliveryoption,
                Availabilitytype = Availabilitytype,
                Deliverydays = Deliverydays,
                Orderminimum = Orderminimum,
                Ordermaximum = Ordermaximum,
                Leadtime = Leadtime,

            };
        }

    }
}