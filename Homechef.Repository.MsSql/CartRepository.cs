using System;
using Dapper;
using Homechef.Domain;
using Homechef.Data;
using System.Linq;


namespace Homechef.Repository.MsSql
{
    public class CartRepository : RepositoryBase
    {

        public int Create(Cart cart)
        {
            var sql = @"INSERT INTO cart (customer_id, chef_id,orderdate,total,status) 
                        OUTPUT inserted.id
                        VALUES (@customer_id,@chef_id,getdate(),@total,'Order Request Send')";
            var data = Cart_data.FromDomain(cart);

            int cartid =  _db.Query<int>(sql, data).FirstOrDefault();
            return (cartid);

        }
        public Cart ToDomain(Cart_data cartdata)
        {
            return new Cart
            {
                Id = cartdata.id,
                Customer_id = cartdata.customer_id,
                Chef_id = cartdata.chef_id,
                Orderdate = cartdata.orderdate,
                Total = cartdata.total,
                Status= cartdata.status,
            
                
           

            };

        }
}
}
