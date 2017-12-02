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

        public TimeSpan Duration(DateTime start, DateTime stop)
        {
            return stop - start;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var start = stopwatch.Start();
            System.Threading.Thread.Sleep(5000);
            var stop = stopwatch.Stop();


            var duration = stopwatch.Duration(start, stop);
            Console.WriteLine(duration);
        }
    }
}
