using System;

namespace ConsoleApplication1.Workflow
{
    public class VideoUploader: IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Upload a video to a cloud storage.");
        }
    }
}