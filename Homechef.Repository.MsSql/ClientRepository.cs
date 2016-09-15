using System;
using Dapper;
using Homechef.Domain;
using Homechef.Data;
using System.Linq;

namespace Homechef.Repository.MsSql
{
   public class ClientRepository: RepositoryBase
    {
        public void Create(Client client)
        {
            var sql = @" IF  EXISTS (SELECT 1 FROM [user] WHERE email = @email)
        BEGIN
                DECLARE @userid int
				SELECT @userid =id FROM [user] where email = @email
               
              IF NOT EXISTS (SELECT 1 FROM client WHERE user_id= @userid)

            BEGIN  
                 INSERT INTO client
                     (firstname,lastname,idnumber,mobile,user_id)
                    VALUES 
                     (@firstname,@lastname,@idnumber,@mobile,@userid)
            END
       END";

            var data = Client_data.FromDomain(client);
            _db.Execute(sql, data);
        }

        //public Client CheckClientbyuser_id(int id)
        //{
        //    var sql = @"SELECT id,user_id FROM chef where user_id = @id ";

        //    var client = _db.Query<Client_data>(sql, new { id }).FirstOrDefault();

        //    return client?.ToDomain();
        //}
    }
}
