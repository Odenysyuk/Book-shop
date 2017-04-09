using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Publication
    /// </summary>
    public  abstract class Publication 
    {
        /// <summary>
        /// Gets or sets author id
        /// </summary>
        public int PublicationId { get; set; }

        /// <summary>
        /// Gets or sets title of publication
        /// </summary>
        [Required, MaxLength(50), MinLength(2)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets number of pages
        /// </summary>
        [Required]
        public int Pages { get; set; }

        /// <summary>
        /// Gets or sets author of publication
        /// </summary>
        public DateTime? PublicationDate { get; set; }

        /// <summary>
        /// Gets or sets pricings
        /// </summary>
        public virtual Pricing Pricing { get; set; }

        public Publication()
        {

        }
    }
}
