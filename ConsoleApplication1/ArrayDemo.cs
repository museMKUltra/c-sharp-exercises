using System;

namespace ConsoleApplication1
{
    public class ArrayDemo
    {
        public void Demonstration()
        {
            var numbers = new[] {3, 7, 9, 4, 2};
            Console.WriteLine(numbers.Length);

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
                Console.WriteLine(n);

            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var n in another)
                Console.WriteLine(n);

            Array.Sort(numbers);
            foreach (var n in numbers)
                Console.WriteLine(n);

            Array.Reverse(numbers);
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}