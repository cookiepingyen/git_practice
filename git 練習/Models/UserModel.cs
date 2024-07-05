using System;

namespace git_練習.Models
{
    public class UserModel
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }

        public UserModel(string name, string email, string password, string address, string phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Address = address;
            Phone = phone;
        }
    }
}