using System.Linq;
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
DECLARE @userid int
					 SELECT @userid =id FROM [user] where email = @email AND PASSWORD = @password
INSERT INTO chef(firstname,lastname,idnumber,age,sex,mobile,streetname,suburb,city,province,postalcode,country,chefpicture,description,user_id)
                    VALUES (@firstname,@lastname,@idnumber,@age,@sex,@mobile,@streetname,@suburb,@city,@province,@postalcode,@country,@chefpicture,@description,@userid)
                   
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

        public Chef GetByUserId(int userId)
        {
            var sql = "SELECT A.*,B.email from chef A,[user] B where A.user_id = @userId AND B.id = @userId";

            var chefData = _db.Query<Chef_data>(sql, new {userId}).First();
            return toDomain(chefData);
        }

        private Chef toDomain(Chef_data chefData)
        {
            return new Chef
            {
                Id = chefData.id,
                Firstname = chefData.firstname,
                Lastname =chefData.lastname,
                Idnumber = chefData.idnumber,
                Age = chefData.age,
                Sex =chefData.sex,
                Mobile = chefData.mobile,
                Streetname =chefData.streetname,
                Suburb =chefData.suburb,
                City =chefData.city,
                Province = chefData.province,
                Postalcode= chefData.postalcode,
                Country = chefData.country,
                Chefpicture =chefData.chefpicture,
                Description =chefData.description,
                Email = chefData.email,
       
    };
        }
    }
}
