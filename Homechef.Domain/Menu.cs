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
    }
}