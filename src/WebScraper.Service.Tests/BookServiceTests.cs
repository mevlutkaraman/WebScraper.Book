using NUnit.Framework;
using System.Linq;

namespace WebScraper.Service.Tests
{
    public class BookServiceTests
    {
        #region Fields

        private IBookService _bookService;

        #endregion

        #region Setup

        [SetUp]
        public void Setup()
        {
            _bookService = new BookCsvService();
        }

        #endregion

        #region Tests

        [Test]
        public void GetAllCsvBooks()
        {
            var books = _bookService.GetAllBooks();
            Assert.IsTrue(books.Any());
        }

        #endregion
    }
}