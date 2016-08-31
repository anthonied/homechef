using System;
using System.Runtime.InteropServices;
using Dapper;
using Homechef.Domain;
using Homechef.Data;

namespace Homechef.Repository.MsSql
{
   public  class MenuRepository: RepositoryBase
    {
        public void Create(Menu menu)
        {
            var sql = @"";
            var data = Menu_data.FromDomain(menu);
            _db.Execute(sql, data);
        }
    }
}
