using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public class DbCommand
    {
        public DbConnection DbConnection { get; set; }
        public string Instruction { get; set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null || string.IsNullOrEmpty(instruction))
            {
                throw new InvalidOperationException();
            }
            DbConnection = dbConnection;
            Instruction = instruction;
        }

        public void Execute()
        {
            DbConnection.Open();
            Console.WriteLine("Run the instruction: " + Instruction);
            DbConnection.Close();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection(@"Server=myServerAddress;Database=myDataBase;User Id=myUsername;
            Password = myPassword;");

            sql.Open();
            sql.Close();

            var oracle = new OracleConnection(@"Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;
Integrated Security=no;");

            oracle.Open();
            oracle.Close();

//            var dbCommand = new DbCommand(sql, "This is the instruction for SQL");

            var dbCommand = new DbCommand(oracle, "This is the instruction for Oracle");
            dbCommand.Execute();
        }
    }
}
