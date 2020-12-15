using System;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var person = Person.Parse("John", "Smith");
            person.Introduce("Mosh");

            var customer = new Customer(2, "Jason");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Orders);
        }
    }
}