using System;

namespace PolymorphismTaskMosh
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override TimeSpan TimeSpan { get; protected set; }
        public override void Open()
        {
            Console.WriteLine("Oracle Database connection opened.");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Database connection closed.");
        }
    }
}