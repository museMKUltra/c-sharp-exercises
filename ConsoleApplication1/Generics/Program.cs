using System;
using System.Diagnostics;

namespace ConsoleApplication1.Generics
{
    // five types of contracts
    /*
     * where T : IComparable -> for interface
     * where T : Produce -> for class or its subclasses
     * where T : struct -> for value types
     * where T : class -> for reference types
     * where T : new() -> for default constructor
     */
    public static class Program
    {
        public static void Run()
        {
            var list = new List();
            list.Add(1);
            Console.WriteLine(list[0]);

            var objectList = new ObjectList();
            objectList.Add("one");
            Console.WriteLine(objectList[0]);
            objectList.Add(2);
            Console.WriteLine(objectList[1]);

            var genericList = new GenericList<string>();
            genericList.Add("generic list one");
            Console.WriteLine(genericList[0]);

            var utilities = new Utilities<string>();
            Console.WriteLine(utilities.Max(3, 4));
            Console.WriteLine(utilities.Max("4", "5"));

            var genericDictionary = new GenericDictionary<string, string>();
            genericDictionary.Add("first", "generic dictionary one");
            Console.WriteLine(genericDictionary["first"]);

            var discountCalculator = new DiscountCalculator<Product>();
            var product = new Product() {Price = 33.33f, Title = "title"};
            Console.WriteLine(discountCalculator.CalculateDiscount(product));

            var nullable1 = new Nullable<int>(5);
            Console.WriteLine(nullable1.HasValue);
            Console.WriteLine(nullable1.GetValueOrDefault());

            var nullable2 = new Nullable<int>();
            Console.WriteLine(nullable2.HasValue);
            Console.WriteLine(nullable2.GetValueOrDefault());
        }
    }
}