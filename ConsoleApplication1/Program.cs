using System;
using ConsoleApplication1.Math;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie.Expire = DateTime.Today.AddDays(5);
            cookie["name"] = "Mosh";
            var name = cookie["name"];
        }

        public static void UseParse()
        {
            int number;
            var result = int.TryParse("2", out number); // return boolean
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }

        public static void UsePoints()
        {
            try
            {
                var point = new Point(3, 4);
                point.Move(null);
                Console.WriteLine(point.X);
                Console.WriteLine(point.Y);

                point.Move(100, 200);
                Console.WriteLine(point.X);
                Console.WriteLine(point.Y);
            }
            catch (Exception e)
            {
                // Console.WriteLine("An unexpected error occured.");
                Console.WriteLine(e);
            }
        }
    }
}