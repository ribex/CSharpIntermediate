using System;

namespace PolymorphismExercise
{
    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Opening the SQL connection...");
            var start = DateTime.Now;
            Timeout = new TimeSpan(0, 0, 0, 7);
            var connected = false;

            while (!connected)
            {
                if (TimeSpan.Compare((DateTime.Now - start), Timeout) > 0)
                {
                    throw new TimeoutException();
                }

                Console.WriteLine("Connected!");
                connected = true;
            }
        }

        public override void Close()
        {
            Console.WriteLine("Closing the SQL connection.");
        }

        public SqlConnection(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}