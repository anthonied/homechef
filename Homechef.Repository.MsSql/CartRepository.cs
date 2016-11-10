using System;
using Dapper;
using Homechef.Domain;
using Homechef.Data;
using System.Linq;

namespace Homechef.Repository.MsSql
{
    public class CartRepository : RepositoryBase
    {

        public void Create(Cart cart)
        {
            var sql = @"";
            var data = Cart_data.FromDomain(cart);
            _db.Execute(sql, data);
        }
        public Cart ToDomain(Cart_data cartdata)
        {
            return new Cart
            {
                Id = cartdata.id,
                Customerid = cartdata.customer_id,
                Chefid = cartdata.chef_id,
                
           

            };

        }
}
}
