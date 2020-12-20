using System;

namespace ConsoleApplication1.DB
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException();

            this.ConnectionString = connectionString;
        }

        public virtual void Open()
        {
            if (Timeout > TimeSpan.FromSeconds(30))
                throw new TimeoutException();
        }

        public abstract void Close();

        public static void Run()
        {
            Console.WriteLine("Please enter an connection string: ");
            var readLine = Console.ReadLine();
            var sqlConnection = new SqlConnection(readLine) {Timeout = TimeSpan.Zero};
            var sqlCommand = new DbCommand(sqlConnection, "sql expression");
            sqlCommand.Execute();

            var oracleConnection = new OracleConnection(readLine) {Timeout = TimeSpan.Zero};
            var oracleCommand = new DbCommand(oracleConnection, "oracle expression");
            oracleCommand.Execute(); 
        }
    }
}