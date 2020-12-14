using System;

namespace ConsoleApplication1
{
    public static class TimeSpanDemo
    {
        public static void Demonstration()
        {
            // create -> hours:minutes:seconds
            var timeSpan = new TimeSpan(1,2,3); // 01:02:03
            Console.WriteLine(timeSpan.ToString()); // 01:02:03
            Console.WriteLine(TimeSpan.Parse("01:02:03")); // 01:02:03
            
            var fromHours = new TimeSpan(1,0,0); // 01:00:00
            Console.WriteLine(TimeSpan.FromHours(1)); // 01:00:00

            var start = DateTime.Now;
            var end = DateTime.Now.AddHours(1);
            var duration = end - start; // 01:00:00.0057190
            
            // properties
            Console.WriteLine(timeSpan.Minutes); // 2
            Console.WriteLine(timeSpan.TotalMinutes); // 62.05
            
            // add
            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8))); // 01:10:03
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(2))); // 01:00:03
        }
    }
}