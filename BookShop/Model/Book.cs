using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Book
    /// </summary>
    public class Book: Publication
    {
        /// <summary>
        /// Gets or sets book id
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets fenre of publication
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Gets or sets author of publication
        /// </summary>
        public Author AuthorOfPublication { get; set; }

        public Book()
        {

        }
    }
}
