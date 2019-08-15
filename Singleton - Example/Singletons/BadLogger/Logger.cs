using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BadLogger
{
    /// <summary>
    /// Class for logging arbitrary messages to file.
    /// </summary>
    public class Logger
    {
        private const string LOG_FILE_NAME = "log.txt";

        /// <summary>
        /// Creates a log file using the log file name.
        /// </summary>
        public Logger()
        {
            using (File.Create(LOG_FILE_NAME)) { }
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
