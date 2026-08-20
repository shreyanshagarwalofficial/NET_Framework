using System;
namespace Assignment_3
{
    abstract class Notification
    {
        public abstract void SendNotification();
    }
    class EmailNotification : Notification
    {
        public override void SendNotification()
        {
            Console.WriteLine("Email notification sent.");
        }
    }
    class SpecialNotification : EmailNotification
    {
        private SpecialNotification()
        {
        }
        public static void ShowMessage()
        {
            Console.WriteLine("Special notification sent.");
        }
    }
    // i am unable to create object of this class because constructor is private
    // SpecialNotification obj = new SpecialNotification();
    class NotificationC
    {
        static void Main(string[] args)
        {
            EmailNotification email = new EmailNotification();
            email.SendNotification();
            SpecialNotification.ShowMessage();
        }
    }
}