using System;

namespace ConsoleApplication1.DB
{
    public class DbCommand
    {
        public DbConnection Connection { get; set; }
        public string Instruction { get; set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
                throw new ArgumentNullException("connection");
            Connection = connection;

            if (instruction == null)
                throw new ArgumentNullException("instruction");
            Instruction = instruction;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine("running {0}", Instruction);
            Connection.Close();
        }
    }
}