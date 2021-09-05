using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Logging
{
    /// <summary>
    /// Log items values with data
    /// </summary>
    public class LogItem
    {
        /// <summary>
        /// Gets or sets log created date
        /// </summary>
        public DateTime Date { get; set; }
        
        /// <summary>
        ///Gets or sets log short message 
        /// </summary>
        public string ShortMessage { get; set; }

        /// <summary>
        ///Gets or sets full message 
        /// </summary>
        public string FullMessage { get; set; }
    }
}
