using NUnit.Framework;
using System;

namespace WebScraper.Logging.Tests
{
    public class LogTests
    {
        #region Fields

        private ILogger _logger;

        #endregion

        #region SetUp

        [SetUp]
        public void Setup()
        {
            _logger = LoggerFactory.CreateLogger();
        }
        #endregion

        #region Tests

        [Test]
        public void CreateDefultLog()
        {
            var logItem = new LogItem { Date = DateTime.Now, ShortMessage = "Test1", FullMessage = "Test2" };
            try
            {
                _logger.CreateLog(logItem);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);
            }   
        }

        #endregion
    }
}