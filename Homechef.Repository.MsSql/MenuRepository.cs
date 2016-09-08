using System.Collections.Generic;
using System.Linq;
using Dapper;
using Homechef.Domain;
using Homechef.Data;

namespace Homechef.Repository.MsSql
{
   public  class MenuRepository: RepositoryBase
    {
        public void Create(Menu menu)
        {
            var sql = @"INSERT INTO menu(chefid,dishname,dishcategory,cuisinetype,pricepp,currency,description,dishimage,takeaway,dineinwithchef,homedelivery,availabilitytype,availableonmonday,availableontuesday,availableonwednesday,availableonthursday,availableonfriday,availableonsaturday,availableonsunday,orderminimum,ordermaximum,leadtime)
                        VALUES(@chefid,@dishname,@dishcategory,@cuisinetype,@pricepp,@currency,@description,@dishimage,@takeaway,@dineinwithchef,@homedelivery,@availabilitytype,@availableonmonday,@availableontuesday,@availableonwednesday,@availableonwednesday,@availableonfriday,@availableonsaturday,@availableonsunday,@orderminimum,@ordermaximum,@leadtime)";
            var data = Menu_data.FromDomain(menu);
            _db.Execute(sql, data);
        }

        public Menu ToDomain(Menu_data menudata)
        {
            return new Menu
            {
                Id = menudata.id,
                Chefid = menudata.chefid,
                Dishname = menudata.dishname,
                Dishcategory = menudata.dishcategory,
                Cuisinetype = menudata.cuisinetype,
                Pricepp = menudata.pricepp,
                Currency = menudata.currency,
                Description = menudata.description,
                Dishimage = menudata.dishimage,
                Takeaway = menudata.takeaway,
                Dineinwithchef = menudata.dineinwithchef,
                Homedelivery = menudata.homedelivery,
                Availabilitytype = menudata.availabilitytype,
                Availableonmonday = menudata.availableonmonday,
                Availableontuesday = menudata.availableontuesday,
                Availableonwednesday = menudata.availableonwednesday,
                Availableonthursday = menudata.availableonthursday,
                Availableonfriday = menudata.availableonfriday,
                Availableonsaturday = menudata.availableonsaturday,
                Availableonsunday = menudata.availableonsunday,
                Orderminimum = menudata.orderminimum,
                Ordermaximum = menudata.ordermaximum,
                Leadtime = menudata.leadtime,

            };
         

        }

        public List<Menu> GetManyMenubyUserId(int userId)
        {
            var sql = @"IF EXISTS (SELECT 1 FROM menu ,chef,[user]where [user].id = @userId AND chef.user_id = @userId
                        AND chef.id = menu.chefid)

BEGIN

SELECT C.* FROM [user] A,chef B,menu C where
                         A.id = @userId AND B.user_id = @userId
                        AND B.id = C.chefid
END";
            var menuData = _db.Query<Menu_data>(sql, new {userId}).ToList();
            return menuData.Select(ToDomain).ToList();
        }
    }
}
