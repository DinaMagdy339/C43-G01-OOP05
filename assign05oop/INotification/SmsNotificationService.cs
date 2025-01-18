using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign05oop.INotification
{
    internal class SmsNotificationService : INotificationService
    {
        EmailNotificationService email = new EmailNotificationService();
        public void SendNotification(string recipient, string message) 
        {
            Console.WriteLine($"message for you {recipient} from {email.Email} ");
        }

    }
}
