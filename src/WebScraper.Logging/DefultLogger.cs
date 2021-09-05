using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScraper.Configuration;

namespace WebScraper.Logging
{
    /// <summary>
    ///Defult text file logger 
    /// </summary>
    public class DefultLogger : ILogger
    {
        #region Fields

        private AppSettings _appSettings;

        #endregion

        #region Ctor

        public DefultLogger()
        {
            _appSettings = new AppSettings();
        }


        #endregion

        /// <summary>
        ///Create a log 
        /// </summary>
        /// <param name="logItem">Created log item value<</param>
        public void CreateLog(LogItem logItem)
        {
            if (logItem == null)
               throw new ArgumentNullException("logItem");

            if (string.IsNullOrEmpty(logItem.ShortMessage))
                throw new ArgumentNullException("logItem.ShortMessage");

            if (logItem.Date == DateTime.MinValue)
                logItem.Date = DateTime.Now;

            // Create a string with a line of text.
            string log = "Date: " + logItem.Date + " ShortMessage: " + logItem.ShortMessage + " FullMesssage: " 
                          + logItem.FullMessage + Environment.NewLine;
            CreateLog(log);
        }

        /// <summary>
        ///Create text file log 
        /// </summary>
        /// <param name="value">log value</param>
        private void CreateLog(string value)
        {
            string logDirectoryPath;
            if (string.IsNullOrEmpty(_appSettings.LoggingConfig.TxtFileLogDirectoryPath))
                logDirectoryPath = Directory.GetCurrentDirectory() + "\\Log";
            else
                logDirectoryPath = _appSettings.LoggingConfig.TxtFileLogDirectoryPath;

            if (!Directory.Exists(logDirectoryPath))
                Directory.CreateDirectory(logDirectoryPath);

            string logfileName = "Log_" + DateTime.Now.ToShortDateString() + ".txt";
            logfileName = logfileName.Replace("/", "_");

            string logFilePath = logDirectoryPath + "//" + logfileName;
            if (!File.Exists(logFilePath))
                File.Create(logFilePath);

            using StreamWriter writer = File.AppendText(logFilePath);
            writer.WriteLine(value);
        }
    }
}
