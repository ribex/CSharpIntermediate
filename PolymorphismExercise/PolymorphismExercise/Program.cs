using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
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
        }
    }
}
