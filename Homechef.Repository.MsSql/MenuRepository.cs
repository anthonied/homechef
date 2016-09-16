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
            var sql = @"INSERT INTO menu(chef_id,dishname,dishcategory,cuisinetype,pricepp,currency,description,dishimage,takeaway,dineinwithchef,homedelivery,availabilitytype,availableonmonday,availableontuesday,availableonwednesday,availableonthursday,availableonfriday,availableonsaturday,availableonsunday,orderminimum,ordermaximum,leadtime,status)
                        VALUES(@chef_id,@dishname,@dishcategory,@cuisinetype,@pricepp,@currency,@description,@dishimage,@takeaway,@dineinwithchef,@homedelivery,@availabilitytype,@availableonmonday,@availableontuesday,@availableonwednesday,@availableonwednesday,@availableonfriday,@availableonsaturday,@availableonsunday,@orderminimum,@ordermaximum,@leadtime,'Active')";
            var data = Menu_data.FromDomain(menu);
            _db.Execute(sql, data);
        }

        public Menu ToDomain(Menu_data menudata)
        {
            return new Menu
            {
                Id = menudata.id,
                Chef_id = menudata.chef_id,
                Dishname = menudata.dishname,
                Dishcategory = menudata.dishcategory,
                Cuisinetype = menudata.cuisinetype,
                Pricepp = menudata.pricepp,
                Currency = menudata.currency,
                Description = menudata.description,
                Dishimage = menudata.dishimage,
                CanOrderAsTakeaway = menudata.takeaway,
                CanOrderAsDineinwithchef = menudata.dineinwithchef,
                CanOrderAsHomedelivery = menudata.homedelivery,
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
                Status =menudata.status,

            };
         

        }

        public List<Menu> GetManyMenubyUserId(int userId)
        {
            var sql = @"IF EXISTS (SELECT 1 FROM menu ,chef,[user]where [user].id = @userId AND chef.user_id = @userId
                        AND chef.id = menu.chef_id)

BEGIN

SELECT C.* FROM [user] A,chef B,menu C where
                         A.id = @userId AND B.user_id = @userId
                        AND B.id = C.chef_id
ORDER BY C.status
END";
            var menuData = _db.Query<Menu_data>(sql, new {userId}).ToList();
            return menuData.Select(ToDomain).ToList();
        }
    }
}
