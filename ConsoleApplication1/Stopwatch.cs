using System;

namespace ConsoleApplication1
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isStarted = false;

        private TimeSpan Duration
        {
            get
            {
                if (_isStarted) SetEndTime();
                return _endTime - _startTime;
            }
        }

        public void Run()
        {
            Console.WriteLine("Power On...");
            while (true)
            {
                Console.WriteLine("Enter 'start', 'stop', 'check' to command: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "start":
                        Start();
                        break;
                    case "stop":
                        Stop();
                        break;
                    case "check":
                        Console.WriteLine(Duration);
                        break;
                    default:
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("Thanks for your attention...");
                            return;
                        }
                        break;
                }
            }
        }

        private void SetEndTime()
        {
            _endTime = DateTime.Now;
        }

        private void Start()
        {
            if (_isStarted)
                throw new InvalidOperationException("It's already started.");

            _isStarted = true;
            _startTime = DateTime.Now;
        }

        private void Stop()
        {
            if (!_isStarted)
            {
                Console.WriteLine("Please start first...");
                return;
            }
            _isStarted = false;
            SetEndTime();
        }
    }
}