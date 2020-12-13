using System;

namespace ConsoleApplication1
{
    public class RandomDemo
    {
        public void Demonstration()
        {
            var random = new Random();
            var charLength = 10;
            var buffer = new char[charLength];

            for (int i = 0; i < charLength; i++)
                buffer[i] = (char) ('a' + random.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}