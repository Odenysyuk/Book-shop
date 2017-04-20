using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace BookShop.Model
{
    /// <summary>
    /// Representation instance of BookShopContext
    /// </summary>
    class BookShopContext : DbContext
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

        public BookShopContext() : base("SchoolDBConnectionString")
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
    }
}
