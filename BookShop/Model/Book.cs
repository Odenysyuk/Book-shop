using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Book
    /// </summary>
    [Table("Books")]
    public class Book: Publication
    {
        ///// <summary>
        ///// Gets or sets book id
        ///// </summary>
        //public int BookId { get; set; }

        /// <summary>
        /// Gets or sets fenre of publication
        /// </summary>
        [Required, MaxLength(50)]
        public string Genre { get; set; }

        /// <summary>
        /// Gets or sets author id
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets or sets author of publication
        /// </summary>
        [ForeignKey("AuthorId")]
        public Author AuthorOfPublication { get; set; }

        public Book(){}
    }
}
