using System;
using System.Security.Cryptography.X509Certificates;
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
            var sql = @"IF NOT EXISTS (SELECT 1 FROM [user] WHERE email = @email)

BEGIN

INSERT INTO [user](email,password)
                    VALUES(@email,@password)
INSERT INTO chef(firstname,lastname,idnumber,age,sex,mobile,streetname,suburb,city,province,postalcode,country,chefpicture,description)
                    VALUES (@firstname,@lastname,@idnumber,@age,@sex,@mobile,@streetname,@suburb,@city,@province,@postalcode,@country,@chefpicture,@description)
                   
END
ELSE
BEGIN
	DECLARE
	@login varchar(20) 
	SET @login='Already got an account with this email'
END
SELECT @login";
        var data = Chef_data.FromDomain(chef);
        var result =_db.Execute(sql, data);
            





            // var sql = @"INSERT INTO [user](email,password)
            //         VALUES(@email,@password)INSERT INTO chef(firstname,lastname,idnumber,age,sex,mobile,streetname,suburb,city,province,postalcode,country,chefpicture,description)
            //         VALUES (@firstname,@lastname,@idnumber,@age,@sex,@mobile,@streetname,@suburb,@city,@province,@postalcode,@country,@chefpicture,@description)
            //         ";
            // var data = Chef_data.FromDomain(chef);
            // _db.Execute(sql, data);



        }

    }
}
