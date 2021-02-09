using System;

namespace ClassesWithMoshExercises
{
    class Stopwatch
    {
        private bool _started;
        private DateTime RecordTime { get;  set; }
        private TimeSpan Elapsed { get;  set; }

        public Stopwatch()
        {
            _started = false;
        }
        public void Start()
        {
            if (_started != false)
                throw new InvalidOperationException("You can not start twice!");

            RecordTime = DateTime.Now;
            _started = true;
        }

        public void Stop()
        {
            Elapsed = DateTime.Now - RecordTime;
            _started = false;
        }

        public void show()
        {
            Console.WriteLine("Elapsed time: {0}", Elapsed);
        }
    }
}