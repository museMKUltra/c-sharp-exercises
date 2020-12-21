using System;

namespace ConsoleApplication1.Workflow
{
    public class StatusChanger: IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database to “Processing”.");
        }
    }
}