using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using BookShop.Model;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Book
    /// </summary>
    [Table("Books")]
    public class Book: Publication
    {
        public Book()
        {
            Genres = new HashSet<Genre>();
        }
        
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
        public virtual Author AuthorOfPublication { get; set; }
        
        /// <summary>
        /// Gets or sets related price info
        /// </summary>
        public virtual Pricing Pricing { get; set; }

        /// <summary>
        /// Gets or sets related genres
        /// </summary>
        public virtual ICollection<Genre> Genres { get; set; }

        /// <summary>
        /// Gets or sets collection of orders
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }
    }
}
