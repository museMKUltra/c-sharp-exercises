namespace ConsoleApplication1.Extensibility
{
    public static class Program
    {
        public static void Run()
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            var migrator = new DbMigrator(new FileLogger(@"/Users/roller/RiderProjects/ConsoleApplication1/log.txt"));
            migrator.Migrate();
        }
    }
}