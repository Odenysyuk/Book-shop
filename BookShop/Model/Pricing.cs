using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        ///// <summary>
        ///// Gets or sets publication
        ///// </summary>   
 
        //public virtual Book Book { get; set; }

        ///// <summary>
        ///// Gets or sets publication
        ///// </summary>       
        //public virtual Magazine Magazines { get; set; }
    }
}
