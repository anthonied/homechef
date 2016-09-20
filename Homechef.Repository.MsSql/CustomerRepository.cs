using System;
using Dapper;
using Homechef.Domain;
using Homechef.Data;
using System.Linq;

namespace Homechef.Repository.MsSql
{
   public class CustomerRepository: RepositoryBase
    {
        public void Create(Customer customer)
        {
            var sql = @" IF  EXISTS (SELECT 1 FROM [user] WHERE email = @email)
        BEGIN
                DECLARE @userid int
				SELECT @userid =id FROM [user] where email = @email
               
              IF NOT EXISTS (SELECT 1 FROM customer WHERE user_id= @userid)

            BEGIN  
                 INSERT INTO customer
                     (firstname,lastname,idnumber,mobile,user_id)
                    VALUES 
                     (@firstname,@lastname,@idnumber,@mobile,@userid)
            END
       END";

            var data = Customer_data.FromDomain(customer);
            _db.Execute(sql, data);
        }

        public Customer GetByUser(User user)
        {
            var sql = "SELECT A.*,B.email from customer A,[user] B where A.user_id = @Id AND B.id = @Id";

            var customerData = _db.Query<Customer_data>(sql, new { user.Id }).First();
            return toDomain(customerData, user);
        }

        private Customer toDomain(Customer_data customerData, User user)
        {
            return new Customer
            {
                Id = customerData.id,
                Firstname = customerData.firstname,
                Lastname = customerData.lastname,
                Idnumber = customerData.idnumber,
                Mobile = customerData.mobile,
                Email = user.Email,

            };
        }

        public void Update(Customer customer)
        {
            var sql = @"UPDATE customer
                        SET
                        firstname = @firstname,
                        lastname = @lastname,
                        idnumber = @idnumber,
                        mobile = @mobile
                         WHERE
                        id = @id
                         ";
            var data = Customer_data.FromDomain(customer);
            _db.Execute(sql, data);
        }
        //public Customer CheckCustomerbyuser_id(int id)
        //{
        //    var sql = @"SELECT id,user_id FROM customer where user_id = @id ";

        //    var customer = _db.Query<Customer_data>(sql, new { id }).FirstOrDefault();

        //    return customer?.ToDomain();
        //}
    }
}
