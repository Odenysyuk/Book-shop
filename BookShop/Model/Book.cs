using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookShop.Model;
using System.Collections.Generic;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Book
    /// </summary>
    [Table("Books")]
    public class Book: Publication
    {
        /// <summary>
        /// Gets or sets book id
        /// </summary>
        [Key]
        public int PublicationId { get; set; }

        /// <summary>
        /// Gets or sets author id
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets or sets author of publication
        /// </summary>
        [ForeignKey("AuthorId")]
        public Author AuthorOfPublication { get; set; }

        //public int PricingId { get; set; }

        //[ForeignKey("PricingId")]
        //public Pricing Pricing { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }

        public Book()
        {
            Genres = new HashSet<Genre>();
        }
    }
}
