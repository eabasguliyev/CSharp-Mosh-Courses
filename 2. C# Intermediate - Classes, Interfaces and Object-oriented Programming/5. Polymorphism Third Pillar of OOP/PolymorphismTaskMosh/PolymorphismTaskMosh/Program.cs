namespace PolymorphismTaskMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("SchoolDatabase");
            var oracleConnection = new OracleConnection("SchoolDatabase");

            //var dbCommand = new DbCommand(sqlConnection, "SELECT * FROM Students");
            var dbCommand = new DbCommand(oracleConnection, "SELECT * FROM Students");

            dbCommand.Execute();
        }
    }
}
