using System;

namespace ConsoleApplication1
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, my name is {FirstName} {LastName}.");
        }

        public static Person Parse(string firstName, string lastName)
        {
            return new Person {FirstName = firstName, LastName = lastName};
        }
    }
}