using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    /// <summary>
    /// Representation instance of Orders
    /// </summary>
    [Table("Orders")]
    public class Order
    {
        /// <summary>
        /// Gets or sets order id
        /// </summary>
        [Key]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets book id
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets amount
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets discount amount
        /// </summary>
        public int DiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets discount percentage
        /// </summary>
        public int DiscounPercentage { get; set; }

        /// <summary>
        /// Gets or sets object of user
        /// </summary>
        public virtual ApplicationUser User { get; set; }

        /// <summary>
        /// Gets or sets collection of book
        /// </summary>
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
    }
}
