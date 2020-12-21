using System;

namespace ConsoleApplication1.Polymorphism
{
    public class SmsNotificationChannel: INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}