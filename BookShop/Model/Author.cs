using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Author
    /// </summary>
    [Table("Authors")]
    public class Author
    {
        /// <summary>
        /// Gets or sets author id
        /// </summary>
        [Key]
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets or sets full name
        /// </summary>
        [Required]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets pen name
        /// </summary>
        [MaxLength(50)]
        public string PenName { get; set; }

        /// <summary>
        /// Gets or sets date of birth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets collection of books
        /// </summary>
        public ICollection<Book> Books { get; set; }
    }
}
