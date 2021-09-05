using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Domain
{
    /// <summary>
    /// Represents a book
    /// </summary>
    public class Book : BaseEntity
    {
        /// <summary>
        ///Gets or sets a value of used ISBN  identifier 
        /// </summary>
        public string IsbnCode { get; set; }

        /// <summary>
        ///Gets or sets title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///Gets or sets number of pages  
        /// </summary>
        public int NumberOfPages { get; set; }

        /// <summary>
        ///Gets or sets author name 
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        ///Gets or sets price value 
        /// </summary>
        public decimal Price { get; set; }
    }
}
