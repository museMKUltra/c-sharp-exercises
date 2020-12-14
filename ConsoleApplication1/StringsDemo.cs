using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public static class StringsDemo
    {
        public static void Demonstration()
        {
            var fullName = "Mosh Hamedani ";
            Console.WriteLine(fullName + "Awesome"); // Mosh Hamedani Awesome
            Console.WriteLine(fullName.Trim() + "Awesome"); // Mosh HamedaniAwesome
            Console.WriteLine(fullName.Trim().ToUpper()); // MOSH HAMEDANI

            var index = fullName.IndexOf(' ');
            Console.WriteLine(fullName.Substring(0, index)); // Mosh
            Console.WriteLine(fullName.Substring(index + 1)); // Hamedani

            var names = fullName.Split(' ');
            Console.WriteLine(names[0]); // Mosh
            Console.WriteLine(names[1]); // Hamedani

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid"); // Invalid

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age); // 25

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0")); // round to $30
        }

        public static string SummarizingText(string text, int maxLength = 20)
        {
            if (text.Length <= maxLength)
                return text;

            var list = new List<string>();
            var totalCount = 0;
            foreach (var t in text.Split(' '))
            {
                list.Add(t);
                totalCount += t.Length;
                if (totalCount < maxLength)
                    continue;
                list.Add("...");
                break;
            }

            return string.Join(" ", list);
        }

        public static void StringBuild()
        {
            var builder = new StringBuilder("Hello World");

            builder
                .Clear()
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            
            Console.WriteLine(builder);
        }
    }
}