using System;

namespace ConsoleApplication1.Workflow
{
    public class VideoEncoder : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding.");
        }
    }
}