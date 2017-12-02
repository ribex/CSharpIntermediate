using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2ExerciseStopwatch
{
    public class Stopwatch
    {

        private bool _startable;

        public Stopwatch()
        {
            _startable = true;
        }
        public DateTime Start()
        {
            // check if stopwatch has not yet been started or has been stopped (but not only-started)
            if (_startable == true)
            {
                _startable = false;
            }
            else
            {
                throw new InvalidOperationException();
            }

            return DateTime.Now;
        }

        public DateTime Stop()
        {
            _startable = true;
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
            var start1 = stopwatch.Start();
            // var unstartable = stopwatch.Start();
            System.Threading.Thread.Sleep(5000);
            var stop1 = stopwatch.Stop();
            var duration1 = stopwatch.Duration(start1, stop1);
            var durationSum = new TimeSpan();
            durationSum += duration1;
            Console.WriteLine(durationSum);

            var start2 = stopwatch.Start();
            System.Threading.Thread.Sleep(1000);
            var stop2 = stopwatch.Stop();
            var duration2 = stopwatch.Duration(start2, stop2);
            durationSum += duration2;
            Console.WriteLine(durationSum);
        }
    }
}
