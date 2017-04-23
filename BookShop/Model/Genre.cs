using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Genre
    /// </summary>
    [Table("Genres")]
    public class Genre
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        /// <summary>
        /// Gets or sets genre id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of genre
        /// </summary>
        [Required, MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Collection of books
        /// </summary>
        public virtual  ICollection<Book> Books { get; set; }
    }
}
