namespace InterfacesAndExtensibility
{
    static class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator = new DbMigrator(new FileLogger("log.txt"));

            dbMigrator.Migrate();
        }
    }
}
