using System.Collections.Generic;

namespace Homechef.Web.Models
{
    public class ChefHomeModel
    {
        public ChefModel Chef { get; set; }
        public List<MenuDisplayModel> Menus { get; set; }
    }
}