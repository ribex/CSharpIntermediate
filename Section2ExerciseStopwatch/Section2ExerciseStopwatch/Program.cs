using System;

namespace Section2ExerciseStopwatch
{
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
