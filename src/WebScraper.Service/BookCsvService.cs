using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using WebScraper.Configuration;
using WebScraper.Domain;

namespace WebScraper.Service
{
    /// <summary>
    /// Book csv service
    /// </summary>
    public class BookCsvService : IBookService
    {
        #region Fields

        private AppSettings _appSettings;

        #endregion

        #region Ctor

        public BookCsvService()
        {
            _appSettings = new AppSettings();
        }

        #endregion


        #region Methods

        /// <summary>
        /// Gets all books
        /// </summary>
        /// <returns>The result books</returns>
        public List<Book> GetAllBooks()
        {
            string filePath = string.Empty;
            if (string.IsNullOrEmpty(_appSettings.BookConfig.CsvFilePath))
                filePath = Directory.GetCurrentDirectory() + "\\App_Data\\books.csv";
            else
            {
                if (!File.Exists(_appSettings.BookConfig.CsvFilePath))
                    throw new FileNotFoundException("Csv file not found.");
                
                filePath = _appSettings.BookConfig.CsvFilePath;
            }
                

            var books = new List<Book>();
            using (var streamReader = new StreamReader(filePath))
            {
                string[] headers = streamReader.ReadLine().Split(';');
                while (!streamReader.EndOfStream)                        
                {
                    string[] rows = streamReader.ReadLine().Split(';');
                    var book = new Book();
                    book.AuthorName = rows[0];
                    book.Title = rows[1];
                    if (decimal.TryParse(rows[2], out decimal price))
                        book.Price = price;
                    book.IsbnCode = rows[3];
                    books.Add(book);
                }
            }
            return books;
        }

        #endregion
    }
}
