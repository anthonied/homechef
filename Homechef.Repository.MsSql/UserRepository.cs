using System.Linq;
using Dapper;
using Homechef.Domain;
using Homechef.Data;

namespace Homechef.Repository.MsSql
{
   public class UserRepository : RepositoryBase
    {
        public User GetByEmail(string email)
        {
            var sql = @"SELECT id, email,password FROM [user] where email = @email ";
          
            var userData = _db.Query<User_data>(sql, new {email}).FirstOrDefault();

            return userData?.ToDomain();
        }


        public void Create(User user)
        {
            var sql = @"IF NOT EXISTS (SELECT 1 FROM [user] WHERE email = @email)

    BEGIN

        INSERT INTO [user](email,password)
                    VALUES(@email,@password)
                          
    END";


            var data = User_data.FromDomain(user);
            var result = _db.Execute(sql, data);
           

        }
}
}
