using System;

namespace ConsoleApplication1.DB
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            Console.WriteLine("initialing sql connection...");
        }

        public override void Open()
        {
            base.Open();
            Console.WriteLine("opening sql connection...");
        }

        public override void Close()
        {
            Console.WriteLine("closing sql connection...");
        }
    }
}