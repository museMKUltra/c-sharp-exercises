using System;

namespace ConsoleApplication1.NullableTypes
{
    public class Program
    {
        public static void Run()
        {
            // DateTime date = null; // won't compile
            Nullable<DateTime> dateOk1 = null; // it's ok
            Console.WriteLine(dateOk1);
            DateTime? dateOk2 = null; // another ok way

            // if null, default value is 1/1/0001 12:00:00 AM 
            Console.WriteLine(dateOk2.GetValueOrDefault()); // 1/1/0001 12:00:00 AM
            Console.WriteLine(dateOk2.HasValue); // False
            // Console.WriteLine(dateOk2.Value); // throw InvalidOperationException

            DateTime? dateTime1 = new DateTime(2020, 12, 12);
            // DateTime dateTime2 = dateTime1; // won't compile
            DateTime dateTime2 = dateTime1.GetValueOrDefault();
            DateTime? dateTime3 = dateTime2;
            Console.WriteLine(dateTime2); // 12/12/2020 12:00:00 AM
            Console.WriteLine(dateTime3); // 12/12/2020 12:00:00 AM

            // Null Coalescing Operator
            DateTime? date = null;
            DateTime date2;

            date2 = date ?? DateTime.Today;
            Console.WriteLine(date2); // 12/24/2020 12:00:00 AM
            // you can also write like these to set date2
            /*
                date2 = date != null ? date.GetValueOrDefault() : DateTime.Today;
                
                if (date != null)
                    date2 = date.GetValueOrDefault();
                else
                    date2 = DateTime.Today;
             */
        }
    }
}