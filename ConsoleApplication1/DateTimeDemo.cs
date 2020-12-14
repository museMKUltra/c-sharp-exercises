using System;

namespace ConsoleApplication1
{
    public static class DateTimeDemo
    {
        public static void Demonstration()
        {
            var dateTime = new DateTime(2020, 12, 10); // 12/10/2020 12:00:00 AM
            var now = DateTime.Now; // 12/14/2020 12:04:30 PM
            var today = DateTime.Today; // 12/14/2020 12:00:00 AM
            
            Console.WriteLine(now.Hour); // 12
            Console.WriteLine(now.Minute); // 4
            Console.WriteLine(now.Second); // 30

            var tomorrow = now.AddDays(1); // 12/15/2020 12:04:30 PM
            var yesterday = now.AddDays(-1); // 12/13/2020 12:04:30 PM

            Console.WriteLine(now.ToLongDateString()); // Monday, December 14, 2020
            Console.WriteLine(now.ToShortDateString()); // 12/14/2020
            Console.WriteLine(now.ToLongTimeString()); // 12:04:30 PM
            Console.WriteLine(now.ToShortTimeString()); // 12:04 PM
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm")); // 2020-12-14 12:04
        }
    }
}