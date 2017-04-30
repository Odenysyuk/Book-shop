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
    /// Representation instance of Blog
    /// </summary>
    [Table("Blogs")]
    public class Blog
    {
        /// <summary>
        /// Gets or sets blog id
        /// </summary>
        [Key]
        public int BlogId { get; set; }

        /// <summary>
        /// Gets or sets create date
        /// </summary>
        [Required]
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// Gets or sets topic
        /// </summary>
        [StringLength(50),Required]
        public String Topic { get; set; }

        /// <summary>
        /// Gets or sets body
        /// </summary>
        [StringLength(50),Required]
        public String Body { get; set; }

        /// <summary>
        /// Gets or sets  use 
        /// </summary>
        public virtual ApplicationUser User { get; set; }

        /// <summary>
        /// Gets or sets  collection  of comment of blog 
        /// </summary>
        public virtual List<BlogComment> Comments { get; set; }
    }
}
