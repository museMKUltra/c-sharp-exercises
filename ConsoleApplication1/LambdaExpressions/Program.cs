using System;
using System.Collections.Generic;

namespace ConsoleApplication1.LambdaExpressions
{
    public static class Program
    {
        public static void Run()
        {
            Console.WriteLine(Square(3));

            // args => expression
            /*
             * () => ...
             * x => ...
             * (x, y, z) => ...
             */
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            var factor = 10;
            Func<int, int> multipler = number => number * factor;
            Console.WriteLine(multipler(5));

            var books = new BookRepository().GetBooks();
            var findAll = books.FindAll(book => book.Price < 10 );
            foreach (var find in findAll) Console.WriteLine(find.Title + " " + find.Price);
        }

        private static int Square(int number)
        {
            return number * number;
        }
    }
}