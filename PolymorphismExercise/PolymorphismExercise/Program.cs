using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
//    public class SqlConnection : DbConnection
//    {
//        public override Open()
//        {
//            
//        }
//    }

    public abstract class DbConnection
    {


        // fields
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }


        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException();
            }
            else
            {
                ConnectionString = connectionString;
            }
        }

        // methods
        public void Open()
        {
            Console.WriteLine("The connection is being opened...");
        }


        public void Close()
        {
            Console.WriteLine("The connection is being closed...");

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
