using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public static class ArrayAndList
    {
        public static void Exercise1()
        {
            var list = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter the name or press enter to display: ");
                var name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    break;
                list.Add(name);
            }

            switch (list.Count)
            {
                case 1:
                    Console.WriteLine("{0} likes your post", list[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post", list[0], list[1]);
                    break;
                default:
                {
                    if (list.Count > 2)
                    {
                        Console.WriteLine("{0}, {1} and {2} others like your post", list[0], list[1], list.Count - 2);
                    }

                    break;
                }
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("please enter the name: ");
            var name = Console.ReadLine();
            if (name == null)
            {
                Console.WriteLine();
                return;
            }

            var chars = new char[name.Length];

            // for (var i = 0; i < name.Length; i++)
            //     chars[i] = name[i];
            // Array.Reverse(chars);
            for (var i = 0; i < name.Length; i++)
                chars[i] = name[name.Length - i - 1];

            var str = new string(chars);
            Console.WriteLine(str);
        }

        public static void Exercise3()
        {
            var ints = new List<int>();
            do
            {
                Console.WriteLine("please enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (ints.Contains(number))
                    Console.WriteLine("the number has existed...");
                else
                    ints.Add(number);
            } while (ints.Count < 5);

            ints.Sort();
            foreach (var i in ints)
                Console.WriteLine(i);
        }

        public static void Exercise4()
        {
            var ints = new List<int>();
            var uniqs = new List<int>();
            while (true)
            {
                Console.WriteLine("enter number or type 'Quit' to quit: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                ints.Add(Convert.ToInt32(input));
            }

            foreach (var i in ints)
                if (!uniqs.Contains(i))
                    uniqs.Add(i);

            foreach (var u in uniqs)
                Console.WriteLine(u);
        }

        public static void Exercise5()
        {
            var ints = new int[5];
            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter a list of comma separated numbers: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid list, please try again");
            }

            for (var i = 0; i < elements.Length; i++)
                ints[i] = Convert.ToInt32(elements[i]);

            Array.Sort(ints);
            for (var i = 0; i < 3; i++)
                Console.WriteLine(ints[i]);
        }
    }
}