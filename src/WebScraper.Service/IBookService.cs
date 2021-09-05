using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScraper.Domain;

namespace WebScraper.Service
{
    /// <summary>
    /// Book service interface
    /// </summary>
    public interface IBookService
    {
        /// <summary>
        /// Gets all books
        /// </summary>
        /// <returns>The result books</returns>
        List<Book> GetAllBooks();
    }
}
