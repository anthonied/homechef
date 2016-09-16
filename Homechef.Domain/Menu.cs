using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homechef.Domain
{
    public class Menu
    {
        public int Id { get; set; }
        public int Chef_id { get; set; }
        
        public string Dishname { get; set; }
        public string Dishcategory { get; set; }
        public string Cuisinetype { get; set; }
        public int Pricepp { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string Dishimage { get; set; }
        public bool CanOrderAsTakeaway { get; set; }
        public bool CanOrderAsDineinwithchef { get; set; }
        public bool CanOrderAsHomedelivery { get; set; }
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

        }

   
}