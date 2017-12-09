using System;

namespace PolymorphismExercise
{
    public abstract class DbConnection
    {
        // fields
        public string ConnectionString { get; set; }
        public static TimeSpan Timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException();
            }
            ConnectionString = connectionString;
        }

        // methods
        public abstract void Open();
        public abstract void Close();
    }
}