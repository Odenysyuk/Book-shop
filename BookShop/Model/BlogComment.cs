using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Model
{
    /// <summary>
    /// Representation instance of BlogComment
    /// </summary>
    [Table("BlogComments")]
    public class BlogComment
    {
        /// <summary>
        /// Gets or sets blog comment id
        /// </summary>
        [Key]
        public int BlogCommentId { get; set; }

        /// <summary>
        /// Gets or sets creting date
        /// </summary>
        [Required]
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// Gets or sets comment
        /// </summary>
        [StringLength(150)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets  use 
        /// </summary>
        public virtual ApplicationUser User { get; set; }

        /// <summary>
        /// Gets or sets  own blog id 
        /// </summary>
        public int OwnBlogId { get; set; }

        /// <summary>
        /// Gets or sets object of own blog  
        /// </summary>
        [ForeignKey("OwnBlogId")]
        public virtual BlogComment OwnBlog { get; set; }
    }
}