using assign05oop.Ishape;
using assign05oop.IAuthentication;
using assign05oop.INotification;
using System.Threading.Channels;

namespace assign05oop 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            //Circle circle = new Circle(5);
            //circle.DisplayShapeInfo();
            //Rectangle rectangle = new Rectangle(3, 6);
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Q2

            //BasicAuthenticationService? basicAuthenticationService = new BasicAuthenticationService();
            //basicAuthenticationService.AuthenticateUser();
            //basicAuthenticationService.AuthorizeUser("Mhmd", "Say By");



            #endregion

            #region Q3
            //Console.WriteLine("Enter your email");
            //string mail = Console.ReadLine() ?? "";
            //EmailNotificationService email = new EmailNotificationService() { Email = mail};
            //Console.WriteLine("Enter to whom you want to send the message");
            //string? recipient = Console.ReadLine() ?? "";
            //Console.WriteLine("enter the message");
            //string? message = Console.ReadLine() ?? "";
            //email.SendNotification(recipient , message );

            //SmsNotificationService ms = new SmsNotificationService();
            //ms.SendNotification(recipient, message);

            //PushNotificationService push = new PushNotificationService();
            //push.SendNotification(recipient, message);

            #endregion
        }
    }
}
