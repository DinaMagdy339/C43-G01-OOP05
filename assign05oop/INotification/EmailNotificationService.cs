using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign05oop.INotification
{
    internal class EmailNotificationService : INotificationService
    {
        public string? Email { get; set; }
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"{Email} sent message ");

        }

    }
}
