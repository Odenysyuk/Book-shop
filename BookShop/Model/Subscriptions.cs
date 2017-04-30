using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Model
{
    /// <summary>
    /// Representation instance of Subscription
    /// </summary>
    [Table("Subscriptions")]
    public class Subscriptions
    {
        /// <summary>
        /// Gets or sets Subscriptions id
        /// </summary>
        [Key]
        public int SubscriptionsId { get; set; }

        /// <summary>
        /// Gets or sets magazine Id
        /// </summary>
        public int MagazineId { get; set; }

        /// <summary>
        /// Gets or sets subscription types id
        /// </summary>
        public int SubscriptionTypesId { get; set; }

        /// <summary>
        /// Gets or sets object of subscription types
        /// </summary>
        [ForeignKey("SubscriptionTypesId")]
        public virtual SubscriptionType SubscriptionTypes { get; set; }

        /// <summary>
        /// Gets or sets object of user
        /// </summary>
        public virtual ApplicationUser Users { get; set; }

        /// <summary>
        /// Gets or sets object of magazines
        /// </summary>
        [ForeignKey("MagazineId")]
        public virtual Magazine Magazines { get; set; }
    }
}