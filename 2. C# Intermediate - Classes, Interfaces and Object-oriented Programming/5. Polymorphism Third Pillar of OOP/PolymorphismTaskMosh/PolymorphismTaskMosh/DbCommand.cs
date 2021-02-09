using System;

namespace PolymorphismTaskMosh
{
    public class DbCommand
    {
        public DbConnection DbConnection { get; set; }
        public string Instruction { get; set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("dbConnection can not be null!");

            if (instruction == null)
                throw new ArgumentNullException("instruction can not be null!");

            DbConnection = dbConnection;
            Instruction = instruction;
        }

        public void Execute()
        {
            DbConnection.Open();

            Console.WriteLine(Instruction);

            DbConnection.Close();
        }
    }
}