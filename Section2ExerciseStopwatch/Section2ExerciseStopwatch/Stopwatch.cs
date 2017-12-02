using System;

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
}