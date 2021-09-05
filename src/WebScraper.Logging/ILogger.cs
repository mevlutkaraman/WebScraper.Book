using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Logging
{
    /// <summary>
    /// Loggger interface
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        ///Create a log  
        /// </summary>
        /// <param name="logItem">Created log item value</param>
        void CreateLog(LogItem logItem);
    }
}
