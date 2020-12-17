using System;

namespace ConsoleApplication1
{
    public class Vehicle
    {
        private readonly string _registerNumber;
        //
        // public Vehicle()
        // {
        //     Console.WriteLine("Vehicle initialing...");
        // }

        public Vehicle(string registerNumber)
        {
            _registerNumber = registerNumber;
            Console.WriteLine("Vehicle initialing... {0}", registerNumber);
        }
    }
}