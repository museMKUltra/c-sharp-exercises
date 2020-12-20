using System;
using ConsoleApplication1.Testability;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class OrderProcessorTests
    {
        // METHODNAME_CONDITION_EXPECTATION
        [Test]
        public void Process_OrderIsAlreadyShipped_ThrowAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };
            Assert.That(() => orderProcessor.Process(order),
                Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}