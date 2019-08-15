using System;

namespace SingletonLogger
{
    /// <summary>
    /// Used to demonstrate the logger.
    /// </summary>
    class Worker
    {
        private string _name;
        private int _timesWorked;

        private Logger _logger;

        /// <summary>
        /// Creates a logger with a given name.
        /// </summary>
        /// <param name="name">The name for this logger</param>
        public Worker(string name)
        {
            _name = name;
            _timesWorked = 0;
            _logger = Logger.GetInstance();
        }

        /// <summary>
        /// After doing some work, logs to file how many times this
        /// Worker instance has worked.
        /// </summary>
        public void DoWork()
        {
            // probably some very important work-doing code here
            // then announce that the work has been done
            _logger.Log($"Worker '{_name}' log #{++_timesWorked}");
        }

        /// <summary>
        /// Prints the current log contents to the console.
        /// </summary>
        public void ShowLog()
        {
            Console.WriteLine("Current Log");
            Console.WriteLine(_logger.GetLog());
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            var worker1 = new Worker("1st Worker");
            worker1.DoWork();

            // unlike last time, log is not overwritten here
            var worker2 = new Worker("2nd Worker");
            worker1.DoWork();
            worker2.DoWork();

            // and again, the log remains intact
            var worker3 = new Worker("3rd Worker");
            worker1.DoWork();
            worker2.DoWork();
            worker3.DoWork();

            // represents the full log
            worker3.ShowLog();
        }
    }
}
