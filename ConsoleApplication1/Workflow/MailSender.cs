using System;

namespace ConsoleApplication1.Workflow
{
    public class MailSender: IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Send an email to the owner of the video notifying them that the video started processing.");
        }
    }
}