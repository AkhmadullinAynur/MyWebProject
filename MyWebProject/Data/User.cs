using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Data
{
    public class User
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public User(string name, string surName, string email, string phoneNumber, string password)
        {
            Name = name;
            SurName = surName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }

        public string Name { get; }
        public string SurName { get; }
        public string Email { get; }
        public string PhoneNumber { get; }
        public string Password { get; }

        public static User Admin()
        {
            User admin = new User("Admin", "admin");
            return admin;
        }
    }
}
