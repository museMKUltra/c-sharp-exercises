using System;

namespace ConsoleApplication1
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Name;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}