using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        // Customer() will be called before Customer(int id)
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        // Customer(int id) will be called before Customer(int id, string name)
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}