﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homechef.Web.Models
{
    public class CustomerHomeModel
    {
        public CustomerModel Customer { get; set; }
        public List<MenuDisplayModel> Menus { get; set; }
    }
}