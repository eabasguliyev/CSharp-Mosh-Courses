using System;
using System.Threading;

namespace InterfacesAndExtensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"Migrating started at {DateTime.Now}");

            //details of migrating the database
            Thread.Sleep(1000);

            _logger.LogInfo($"Migrating finished at {DateTime.Now}");
        }
    }
}