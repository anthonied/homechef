using System;
using Homechef.Repository.MsSql;
using Dapper;
using Homechef.Domain;
using Homechef.Data;

namespace Homechef.Repository.MsSql
{
   public class ChefRepository :RepositoryBase
    {
        public void Create(Chef chef)
        {
            var sql = @"INSERT INTO chef(firstname,lastname,age,email,mobile,residentialaddress,idnumber)VALUES (@firstname, @lastname, @age, @email, @mobile, @residentialaddress, @idnumber)";
            var data = Chef_data.FromDomain(chef);
            _db.Execute(sql, data);

        }

    }
}
