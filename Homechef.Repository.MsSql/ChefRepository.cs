﻿using System.Linq;
using Dapper;
using Homechef.Domain;
using Homechef.Data;

namespace Homechef.Repository.MsSql
{
   public class ChefRepository :RepositoryBase
    {
        public void Create(Chef chef)
        {
            var sql = @" IF  EXISTS (SELECT 1 FROM [user] WHERE email = @email)
        BEGIN
                DECLARE @userid int
				SELECT @userid =id FROM [user] where email = @email
               
              IF NOT EXISTS (SELECT 1 FROM chef WHERE user_id= @userid)

            BEGIN  
                 INSERT INTO chef
                     (firstname,lastname,idnumber,age,sex,mobile,streetname,suburb,city,province,postalcode,country,chefpicture,description,user_id)
                    VALUES 
                     (@firstname,@lastname,@idnumber,@age,@sex,@mobile,@streetname,@suburb,@city,@province,@postalcode,@country,@chefpicture,@description,@userid)
            END
       END";

            var data = Chef_data.FromDomain(chef);
            _db.Execute(sql, data);
        }

        public Chef CheckChefbyuser_id(int id)
        {
            var sql = @"SELECT * FROM chef where user_id = @id ";

            var chef = _db.Query<Chef_data>(sql, new { id }).FirstOrDefault();

            return chef?.ToDomain();
        }
        public Chef GetByUser(User user)
        {
            var sql = "SELECT A.*,B.email from chef A,[user] B where A.user_id = @Id AND B.id = @Id";

            var chefData = _db.Query<Chef_data>(sql, new {user.Id}).First();
            return toDomain(chefData, user);
        }
        public void Update(Chef chef)
        {
            var sql = @"UPDATE chef
                        SET
                        firstname = @firstname,
                        lastname = @lastname,
                        idnumber = @idnumber,
                        age = @age,
                        sex = @sex,
                        mobile = @mobile,
                        streetname = @streetname,
                        suburb = @suburb,
                        city = @city,
                        province = @province,
                        postalcode = @postalcode,
                        country = @country,
                        chefpicture = @chefpicture,
                        description = @description

                        WHERE
                        id = @id
                         ";
            var data = Chef_data.FromDomain(chef);
            _db.Execute(sql, data);
        }

        private Chef toDomain(Chef_data chefData, User user)
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
                Email = user.Email,
       
    };
        }
    }
}
