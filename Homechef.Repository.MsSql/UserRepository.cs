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
    }
}
