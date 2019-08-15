using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingletonLogger
{
    /// <summary>
    /// Class for logging arbitrary messages to file.
    /// This logger is a Singleton, to ensure that the log file
    /// is not overwritten during runtime.
    /// </summary>
    public class Logger
    {
        private const string LOG_FILE_NAME = "log.txt";
        private static Logger _instance;

        /// <summary>
        /// Creates a log file using the log file name.
        /// Private to prevent instantiation of Singletons outside this class.
        /// </summary>
        private Logger()
        {
            using (File.Create(LOG_FILE_NAME)) { }
        }

        /// <summary>
        /// Returns a reference to the internal instance of the class.
        /// If the internal instance is null, constructs it.
        /// </summary>
        /// <returns>Reference to internal Logger instance</returns>
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        /// <summary>
        /// Logs a given message to the log file.
        /// </summary>
        /// <param name="message">The message to be logged to file.</param>
        public void Log(string message)
        {
            using (var writer = new StreamWriter(LOG_FILE_NAME, true))
            {
                writer.WriteLine(message);
            }
        }

        /// <summary>
        /// Gets the current content of the log file.
        /// </summary>
        /// <returns>The log file's contents.</returns>
        public string GetLog()
        {
            using (var reader = new StreamReader(LOG_FILE_NAME))
            {
                return reader.ReadToEnd();
            }
        }

    }
}
