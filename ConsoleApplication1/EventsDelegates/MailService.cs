using System;

namespace ConsoleApplication1.EventsDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: sending mail..." + e.Video.Title);
        }
    }
}