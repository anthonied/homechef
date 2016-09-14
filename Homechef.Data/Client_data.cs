using System;
using Homechef.Domain;
namespace Homechef.Data
{
    public class Client_data
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string idnumber { get; set; }
        public int mobile { get; set; }
        public string email { get; set; }

        public static Client_data FromDomain(Client client)
        {
            return new Client_data
            {
                firstname = client.Firstname,
                lastname = client.Lastname,
                idnumber = client.Idnumber,
                mobile = client.Mobile,
                email = client.Email
            };
        }
    }
}
