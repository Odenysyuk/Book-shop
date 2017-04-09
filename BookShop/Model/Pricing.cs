using System.ComponentModel.DataAnnotations;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Pricing (one to one to Publication)
    /// </summary>
    public class Pricing
    {
        /////// <summary>
        /////// Gets or sets pricing id
        /////// </summary>
        //public int Id { get; set; }

        ///// <summary>
        ///// Gets or sets primary and foreign key for Publication
        ///// </summary>
        public int PublicationId { get; set; }    

        ///// <summary>
        ///// Gets or sets price
        ///// </summary>
        public int Price { get; set; }

        ///// <summary>
        ///// Gets or sets publication
        ///// </summary>
        public virtual Publication Publication { get; set; }
    }
}
