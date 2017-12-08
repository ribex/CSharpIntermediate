using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public class DbConnection
    {
        private readonly ConnectionString _connectionString;

        public DbConnection(ConnectionString connectionString)
        {
            if (connectionString == null || connectionString == "")
            {
                throw new InvalidOperationException();
            }
            else
            {
                _connectionString = connectionString;
            }
        }

        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public void Open() { }
        public void Close() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
