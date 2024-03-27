using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    public interface IUser
    {
        string Id { get; set; }
        string Name { get; set; }
        string Role { get; set; }
        string Password { get; set; }
        string Stringify();
        string GetValue(string propertyName);
        void UpdateValue(string propertyName, string payload);
        void Clear();

    }
}
