using System;
using Dapper;
using Homechef.Domain;
using Homechef.Data;
using System.Linq;

namespace Homechef.Repository.MsSql
{
   public class CartitemRepository: RepositoryBase
    {
        public void Create(Cartitem cartitem)
        {
            var sql = @"INSERT INTO cartitem (cart_id, menu_id,quantity,pricepp,subtotal,lastupdated)  VALUES (@cart_id,@menu_id,@quantity,@pricepp,@subtotal,getdate())";
            var data = Cartitem_data.FromDomain(cartitem);
            _db.Execute(sql, data);
        }
        public Cartitem ToDomain(Cartitem_data cartitemdata)
        {
            return new Cartitem
            {
                Id = cartitemdata.id,
                Cart_id = cartitemdata.cart_id,
                Menu_id = cartitemdata.menu_id,
                Quantity = cartitemdata.quantity,
                Pricepp = cartitemdata.pricepp,
                Subtotal = cartitemdata.subtotal,
                Lastupdated = cartitemdata.lastupdated,


             };

        }
    }
}
