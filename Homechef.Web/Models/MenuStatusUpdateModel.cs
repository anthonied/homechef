using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homechef.Web.Models
{
    public class MenuStatusUpdateModel
    {

        public int Id { get; set; }
        public string Status { get; set; }

        public MenuStatusUpdateModel ToDomain()
        {
            return new MenuStatusUpdateModel
            {
                Id = Id,
                Status = Status,
            };


        }

    }
}