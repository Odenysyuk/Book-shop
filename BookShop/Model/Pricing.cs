using System.ComponentModel.DataAnnotations;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Pricing
    /// </summary>
    public class Pricing
    {
        ///// <summary>
        ///// Gets or sets primary and foreign key for Publication
        ///// </summary>
        [Key]       
        public int PricingId { get; set; }

        ///// <summary>
        ///// Gets or sets price
        ///// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets related bool
        /// </summary>   

        public virtual Book Book { get; set; }

        /// <summary>
        /// Gets or sets related magazine
        /// </summary>       
        public virtual Magazine Magazine { get; set; }
    }
}
