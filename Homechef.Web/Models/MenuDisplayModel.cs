using Homechef.Domain;

namespace Homechef.Web.Models
{
    public class MenuDisplayModel
    {
        public int Id { get; set; }
        public int Chefid { get; set; }
        public string Dishname { get; set; }
        public string Dishcategory { get; set; }
        public string Cuisinetype { get; set; }
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

        public static MenuDisplayModel FromDomain(Menu menu)
        {
            return new MenuDisplayModel
            {
                Id = menu.Id,
                Chefid = menu.Chefid,
                Dishname = menu.Dishname,
                Dishcategory = menu.Dishcategory,
                Cuisinetype = menu.Cuisinetype,
                Pricepp = menu.Pricepp,
                Currency = menu.Currency,
                Description = menu.Description,
                Dishimage = menu.Dishimage,
                Takeaway = menu.Takeaway,
                Dineinwithchef = menu.Dineinwithchef,
                Homedelivery = menu.Homedelivery,
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