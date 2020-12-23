using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1.ExtensionMethods
{
    public static class Program
    {
        public static void Run()
        {
            string post = "This is supposed to be a very long long long string...";
            var shortenPost = post.Shorten(5);
            Console.WriteLine(shortenPost);

            var numbers = new List<int> {3, 4, 2, 5, 1};
            var max = numbers.Max();
            Console.WriteLine(max);
        }
    }
}