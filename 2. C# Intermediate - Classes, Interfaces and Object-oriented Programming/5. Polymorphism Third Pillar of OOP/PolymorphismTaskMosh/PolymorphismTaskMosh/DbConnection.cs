using System;

namespace PolymorphismTaskMosh
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; protected set; }
        public abstract TimeSpan TimeSpan { get; protected set; }

        public DbConnection(string connectionString)
        {
            if (connectionString == null)
                throw new ArgumentNullException("Connection string can not be null!");

            ConnectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();
    }
}