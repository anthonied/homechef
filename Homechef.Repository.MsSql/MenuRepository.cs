using System;
using System.Runtime.InteropServices;
using Dapper;
using Homechef.Domain;
using Homechef.Data;

namespace Homechef.Repository.MsSql
{
   public  class MenuRepository: RepositoryBase
    {
        public void Create(Menu menu)
        {
            var sql = @"INSERT INTO menu(dishname,dishcategory,cuisinetype,pricepp,currency,description,dishimage,takeaway,dineinwithchef,homedelivery,availabilitytype,availableonmonday,availableontuesday,availableonwednesday,availableonthursday,availableonfriday,availableonsaturday,availableonsunday,orderminimum,ordermaximum,leadtime)
                        VALUES(@dishname,@dishcategory,@cuisinetype,@pricepp,@currency,@description,@dishimage,@takeaway,@dineinwithchef,@homedelivery,@availabilitytype,@availableonmonday,@availableontuesday,@availableonwednesday,@availableonwednesday,@availableonfriday,@availableonsaturday,@availableonsunday,@orderminimum,@ordermaximum,@leadtime)";
            var data = Menu_data.FromDomain(menu);
            _db.Execute(sql, data);
        }
    }
}
