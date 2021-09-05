using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebScraper.Configuration
{
    /// <summary>
    /// Represents the app settings
    /// </summary>
    public class AppSettings
    {
        #region Ctor

        public AppSettings()
        {
            LoadAppSettingsData();
        }

        #endregion

        #region Utilities

        /// <summary>
        /// Load settings json data
        /// </summary>
        private void LoadAppSettingsData()
        {
            string jsonPath = Directory.GetCurrentDirectory() + "\\appsettings.json";
            var jsonBytes = File.ReadAllBytes(jsonPath);
            var jsonDoc = JsonDocument.Parse(jsonBytes);
            var root = jsonDoc.RootElement;

            var loggingConfigRoot = root.GetProperty("LoggingConfig");
            LoggingConfig.TxtFileLogDirectoryPath = loggingConfigRoot.GetProperty("TxtFileLogDirectoryPath").GetString();

            var bookConfigRoot = root.GetProperty("BookConfig");
            BookConfig.CsvFilePath= bookConfigRoot.GetProperty("CsvFilePath").GetString();

        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets logging configuration parameters
        /// </summary>
        public LoggingConfig LoggingConfig { get; set; } = new LoggingConfig();
        
        /// <summary>
        /// Gets or sets book configuration parameters 
        /// </summary>
        public BookConfig BookConfig { get; set; } = new BookConfig();

        #endregion
    }
}
