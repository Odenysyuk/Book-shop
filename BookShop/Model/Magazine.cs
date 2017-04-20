using System.ComponentModel.DataAnnotations;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Magazine
    /// </summary>
    [Table("Magazines")]
    public class Magazine: Publication
    {
        /// <summary>
        /// Gets or sets magazine id
        /// </summary>
        [Key]
        public int PublicationId { get; set; }

        /// <summary>
        /// Gets or sets categories of magazine
        /// </summary>
        [MaxLength(50)]
        public string Categories { get; set; }

        /// <summary>
        /// Gets or sets frequency of magazine
        /// </summary>
        public int Frequency { get; set; }

        /// <summary>
        /// Gets or sets company of magazine
        /// </summary>
        [MaxLength(20)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or sets related price info
        /// </summary>
        public virtual Pricing Pricing { get; set; }
    }
}
