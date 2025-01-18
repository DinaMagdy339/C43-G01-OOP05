using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign05oop.IAuthentication
{
    internal interface IAuthenticationService 
    {
        public bool AuthenticateUser();
        public bool AuthorizeUser(string userName , string roles);
    }
}
