using System;
using ConsoleApplication1.Enum;

namespace ConsoleApplication1.condition
{
    public class ControlFlow
    {
        public void Exercise1()
        {
            Console.WriteLine("please enter a number");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        public void Exercise2()
        {
            Console.WriteLine("please enter a number");
            var number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("please enter another number");
            var number2 = Int32.Parse(Console.ReadLine());

            var max = number2 > number1 ? number2 : number1;
            Console.WriteLine(max + " is max");
        }

        public void Exercise3()
        {
            Console.WriteLine("please enter width");
            var width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("please enter height");
            var height = Int32.Parse(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }

        public void Exercise4()
        {
            Console.WriteLine("please enter speed limit");
            var limit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("please enter speed km/hr");
            var speed = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1}", limit, speed);
            if (speed > limit)
            {
                var demerit = (float) (speed - limit) / (float) 5;
                if (demerit >= 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("demerit point is {0}", (int) demerit);
                }
            }
            else
            {
                Console.WriteLine("it's safe");
            }
        }
    }
}