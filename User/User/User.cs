using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type;

namespace UserDetails
{
    public class User : Analyzer, IUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User() { }
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public User(string name, string password, string role)
        {
            Name = name;
            Password = password;
            Role = role;
        }

        public User(string id , string name, string password, string role)
        {
            Id = id;
            Name = name;
            Password = password;
            Role = role;
        }

        public string Stringify()
        {
            return $"\nId :\t{Id}\nName : \t{Name}\nRole :\t{Role}";
        }

        public void Clear()
        {
            Id = string.Empty;
            Name = string.Empty;
            Role = string.Empty;
            Password = string.Empty;
        }
    }
}
