using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

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
            modelBuilder.Entity<Book>().Map(m =>
            {
                m.ToTable("Books");
            });

            modelBuilder.Entity<Magazine>().Map(m =>
            {
                m.ToTable("Magazines");
            });

            //modelBuilder.Entity<Book>().HasRequired<Pricing>(p=> p.Pricing).WithOptional(p=>p.Book);
            //modelBuilder.Entity<Magazine>().HasRequired<Pricing>(p => p.Pricing)
            //                               .WithOptional(p => p.Magazines);
            base.OnModelCreating(modelBuilder);

        }
    }
}
