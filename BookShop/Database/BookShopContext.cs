using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BookShop.Model
{
    /// <summary>
    /// Representation instance of BookShopContext
    /// </summary>
    public class BookShopContext : IdentityDbContext<ApplicationUser> //DbContext
    {
        /// <summary>
        /// Gets or sets table of authors
        /// </summary>
        public DbSet<Author> Authors { get; set; }

        /// <summary>
        /// Gets or sets table of publications 
        /// </summary>
        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// Gets or sets table of publications 
        /// </summary>
        public DbSet<Magazine> Magazines { get; set; }

        /// <summary>
        /// Gets or sets table of genres 
        /// </summary>
        public DbSet<Genre> Genres { get; set; }

        /// <summary>
        /// Gets or sets pricings collection.
        /// </summary>
        public DbSet<Pricing> Pricings { get; set; }

        /// <summary>
        /// Gets or sets blog collection
        /// </summary>
        public DbSet<Blog> Blogs { get; set; }

        /// <summary>
        /// Gets or sets comment of blog collection
        /// </summary>
        public DbSet<BlogComment> BlogComments { get; set; }

        /// <summary>
        /// Gets or sets order collection
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets type of subscription collection
        /// </summary>
        public DbSet<SubscriptionType> SubscriptionTypes { get; set; }

        /// <summary>
        /// Gets or sets subscription collection
        /// </summary>
        public DbSet<Subscriptions> Subscriptions { get; set; }
        
        public BookShopContext() : base("BookShop")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BookShopContext>());
        }

        /// <summary>
        /// Created TPC mapping
        /// </summary>
        /// <param name="modelBuilder">object of DbModelBuilder</param>    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pricing>().HasOptional(p => p.Book).WithRequired(p => p.Pricing)
                .Map(configurationAction: new Action<ForeignKeyAssociationMappingConfiguration>(x => x.MapKey("PricingId")));
            modelBuilder.Entity<Pricing>().HasOptional(p => p.Magazine).WithRequired(p => p.Pricing)
                .Map(configurationAction: new Action<ForeignKeyAssociationMappingConfiguration>(x => x.MapKey("PricingId")));

            base.OnModelCreating(modelBuilder);

        }

        /// <summary>
        /// Gets database context instance
        /// </summary>
        /// <returns>Database context</returns>
        public static BookShopContext Create()
        {
            return new BookShopContext();
        }
    }
}
