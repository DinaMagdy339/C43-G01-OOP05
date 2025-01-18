using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign05oop.IAuthentication
{
    internal class Users
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Roles { get; set; }
        public Users(string userName, string password, string roles)
        {
            UserName = userName;
            Password = password;
            Roles = roles;
        }
    }
}
