using System;

namespace PolymorphismTaskMosh
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override TimeSpan TimeSpan { get; protected set; }
        public override void Open()
        {
            Console.WriteLine("Sql Database connection opened.");
        }

        public override void Close()
        {
            Console.WriteLine("Sql Database connection closed.");
        }
    }
}