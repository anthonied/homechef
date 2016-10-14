using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homechef.Web.Models
{
    public class MenuListModel
    {
        
            public ChefModel Chef { get; set; }
            public List<MenuDisplayModel> Menus { get; set; }
        
    }
}