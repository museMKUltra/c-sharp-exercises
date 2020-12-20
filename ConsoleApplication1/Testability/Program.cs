using System;

namespace ConsoleApplication1.Testability
{
    public static class Program
    {
        public static void Run()
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order
            {
                DatePlaced = DateTime.Now,
                TotalPrice = 100f
            };
            orderProcessor.Process(order);
        }
    }
}