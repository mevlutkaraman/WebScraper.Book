using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Logging
{
    /// <summary>
    /// Application looger type
    /// </summary>
    public enum LoggerType
    {
        /// <summary>
        /// Text file logger
        /// </summary>
        Default=10,
        
        /// <summary>
        ///SqlServer database logger
        /// </summary>
        SqlServerDatabase=20,
        
        /// <summary>
        ///MySql database logger
        /// </summary>
        MySqlDatabase=30,

        /// <summary>
        ///PostgreSql database logger 
        /// </summary>
        PostgreSqlDataBase = 40,

        /// <summary>
        ///ElasticSearch index logger 
        /// </summary>
        ElasticSearch = 50,
    }
}
