using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Author
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Gets or sets author id
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets or sets full name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets pen name
        /// </summary>
        public string PenName { get; set; }

        /// <summary>
        /// Gets or sets date of birth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        public Author()
        {

        }
    }
}
