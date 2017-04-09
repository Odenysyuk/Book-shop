using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    /// <summary>
    /// Representation instance of BookShopContext
    /// </summary>
    class BookShopContext : DbContext
    {
        /// <summary>
        /// Gets or sets magazine id
        /// </summary>
        public DbSet<Author> Authors { get; set; }

        /// <summary>
        /// Gets or sets magazine id
        /// </summary>
        public DbSet<Magazine> Magazines { get; set; }

        /// <summary>
        /// Gets or sets magazine id
        /// </summary>
        public DbSet<Book> Books { get; set; }

        public BookShopContext():base("BookShop")
        {

        }
    }
}
