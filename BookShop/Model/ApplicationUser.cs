using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BookShop.Model
{
    /// <summary>
    /// Representation instance of ApplicationUser
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// Gets o sets collection of blog
        /// </summary>
        public virtual ICollection<Blog> Blogs { get; set; }

        /// <summary>
        /// Gets o sets collection of blog comment
        /// </summary>
        public virtual ICollection<BlogComment> BlogComments { get; set; }

        /// <summary>
        /// Gets or sets collection of order
        /// </summary>
        public virtual ICollection<Order> Oders { get; set; }

        /// <summary>
        /// Gets or sets collection of subcriptions
        /// </summary>
        public virtual ICollection<Subscriptions> Subscriptions { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
