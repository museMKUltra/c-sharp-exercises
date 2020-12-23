using System;
using System.Linq;

namespace ConsoleApplication1.Linq
{
    public static class Program
    {
        public static void Run()
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators
            var enumerable1 =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            foreach (var book in enumerable1) Console.Write(book + " ");
            // book book book1 book3
            Console.WriteLine();

            // LINQ Extension Methods
            var enumerable2 = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var book in enumerable2) Console.Write(book + " ");
            // book book book1 book3
            Console.WriteLine();

            // if not found, throw InvalidOperationException 
            var single1 = books.Single(b => b.Title == "booker");
            Console.WriteLine(single1.Title); // booker
            
            // if not found, default empty string
            var single2= books.SingleOrDefault(b => b.Title == "booking");
            Console.WriteLine(single2?.Title); // 

            var first = books.First(b => b.Title == "book");
            Console.WriteLine(first.Price); // 9.99

            var takes = books.Skip(1).Take(2);
            foreach (var book in takes) Console.Write(book.Title + " ");
            // book book
            Console.WriteLine();

            var count = books.Count();
            Console.WriteLine(count); // 3

            var max = books.Max(b => b.Price);
            var min = books.Min(b => b.Price);
            var sum = books.Sum(b => b.Price);
            var average = books.Average(b => b.Price);
            Console.WriteLine($"{max} {min} {sum} {average}");
            // 12 5 26.99 8.996667
        }
    }
}