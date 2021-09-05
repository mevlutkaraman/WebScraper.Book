using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Logging
{
    /// <summary>
    /// Use application logger
    /// </summary>
    public static class LoggerFactory
    {
        /// <summary>
        ///Create a logger interface to class
        /// </summary>
        /// <param name="loggerType">Logger type info</param>
        /// <returns>Instance loger</returns>
        public static ILogger CreateLogger(LoggerType loggerType = LoggerType.Default)
        {
            switch (loggerType)
            {
                case LoggerType.Default:
                    return new DefultLogger();
                case LoggerType.SqlServerDatabase:
                    return new SqlServerDatabaseLogger();
                case LoggerType.MySqlDatabase:
                    return new MySqlDatabaseLogger();
                case LoggerType.PostgreSqlDataBase:
                    return new PostgreSqlDataBaseLogger();
                case LoggerType.ElasticSearch:
                    return new ElasticSearchLogger();
                default:
                    return new DefultLogger();
            }
        }

    }
}
