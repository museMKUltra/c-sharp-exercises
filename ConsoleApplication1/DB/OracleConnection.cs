using System;

namespace ConsoleApplication1.DB
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            Console.WriteLine("initialing oracle connection...");
        }

        public override void Open()
        {
            base.Open();
            Console.WriteLine("opening oracle connection...");
        }

        public override void Close()
        {
            Console.WriteLine("closing oracle connection...");
        }
    }
}