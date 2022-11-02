using System;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; }

        public User () 
        {
            Date = DateTime.Now;
        }

        public User (string username, string name, string password, string email): this()
        {
            Username = username;
            Name = name;
            Password = password;
            Email = email;
        }
    }
}
