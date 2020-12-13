using System;

namespace ConsoleApplication1.Condition
{
    public class Loop
    {
        public void Exercise1()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
                count = i % 3 == 0 ? count + 1 : count;

            Console.WriteLine("there are " + count + " numbers are divisible by 3 between 1 to 100");
        }

        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("enter a number or ok to calculate sum");
                var result = Console.ReadLine();
                if (result.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(result);
            }

            Console.WriteLine("sum is " + sum);
        }

        public void Exercise3()
        {
            Console.WriteLine("\nenter a number");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            for (int i = number; i > 0; i--)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        public void Exercise4()
        {
            var random = new Random();
            var code = random.Next(1, 10);
            Console.WriteLine("code is " + code);
            var times = 0;
            do
            {
                Console.WriteLine("guess a number");
                var number = Convert.ToInt32(Console.ReadLine());
                if (code != number)
                {
                    times++;
                }
                else
                {
                    Console.WriteLine("you won");
                    return;
                }
            } while (times < 4);

            Console.WriteLine("failed");
        }

        public void Exercise5()
        {
            Console.WriteLine("please enter series numbers separated by comma");
            var str = Console.ReadLine();
            var numbers = str.Split(',');
            var max = Convert.ToInt32(numbers[0]);
            foreach (var number in numbers)
            {
                if (Convert.ToInt32(number) > max)
                    max = Convert.ToInt32(number);
            }
            // var result = 0;
            // var max = 0;
            // foreach (var c in str)
            // {
            //     var num = (int) c - 48;
            //     if (num >= 0 && num <= 9)
            //     {
            //         result = result * 10 + num;
            //         max = result > max ? result : max;
            //     }
            //     else
            //     {
            //         result = 0;
            //     }
            // }

            Console.WriteLine("max is " + max);
        }
    }
}