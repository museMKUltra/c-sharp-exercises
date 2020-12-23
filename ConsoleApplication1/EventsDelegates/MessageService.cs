using System;

namespace ConsoleApplication1.EventsDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: sending message..." + e.Video.Title);
        }
    }
}