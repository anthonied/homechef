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
            var sql = @"";
            var data = Cartitem_data.FromDomain(cartitem);
            _db.Execute(sql, data);
        }
        public Cartitem ToDomain(Cartitem_data cartitemdata)
        {
            return new Cartitem
            {
                Id = cartitemdata.id,
                Cartid = cartitemdata.cart_id,
                Menuid = cartitemdata.menu_id,
                Quantity = cartitemdata.quantity,
                Unitprice = cartitemdata.unitprice,
                Totalprice = cartitemdata.totalprice,


             };

        }
    }
}
