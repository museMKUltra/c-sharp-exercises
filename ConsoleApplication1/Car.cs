using System;

namespace ConsoleApplication1
{
    public class Car : Vehicle
    {
        public Car(string registerNumber)
            : base(registerNumber)
        {
            Console.WriteLine("Car initialing... {0}", registerNumber);
        }
    }
}