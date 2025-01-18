using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign05oop.IAuthentication
{
    internal class BasicAuthenticationService : IAuthenticationService 
    {
        Users? Users { get; set; }
        Users[] users =
           {
                new Users("Ahmed" , "wlkj3" , "Say Hello"),
                new Users("Mhmd" , "llln5" , "Say By"),
                new Users("cll" , "gwf" , "Say hi"),
                new Users("akw" , "wff" , "Say by"),
            };

        public bool AuthenticateUser()
        {
            Console.WriteLine("enter you name");
            string? userName = Console.ReadLine();
            Console.WriteLine("anter the password");
            string? password = Console.ReadLine();

            foreach (var user in users)
                if (userName is not null && userName == Users?.UserName && password is not null && password == Users.Password)
                    return true;
                
                    return false;
        }
        public bool AuthorizeUser(string userName , string roles)
        {
            foreach (var user in users)
            {
                if (userName == Users?.UserName && roles == Users.Roles)
                
                        return true;
                
                else
                        return false;    
            }
            return true;
                
        }
    }
}
