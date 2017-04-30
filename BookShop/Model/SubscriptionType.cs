using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Model
{
    /// <summary>
    /// Representation instance of Subscription
    /// </summary>
    [Table("SubscriptionTypes")]
    public class SubscriptionType
    {
        /// <summary>
        /// Gets or sets Subscriptions type id
        /// </summary>
        [Key]
        public int SubscriptionTypeId { get; set; }

        /// <summary>
        /// Gets or sets name
        /// </summary>
        [StringLength(50)]
        public  string Name { get; set; }

        /// <summary>
        /// Gets or sets quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets collection of subscriptions
        /// </summary>
        public virtual List<Subscriptions> Subscription { get; set; }
    }
}
