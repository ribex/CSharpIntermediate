using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2ExerciseStopwatch
{
    public class Stopwatch
    {
        public DateTime Start()
        {
            return DateTime.Now;
        }

        public DateTime Stop()
        {
            return DateTime.Now;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var duration = stopwatch.Stop() - stopwatch.Start();
            Console.WriteLine(duration);
        }
    }
}
