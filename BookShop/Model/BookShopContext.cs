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

        // TODO: Чому ми не може тут створити два DbSet<Book> і  DbSet<Magazine>, воно створить теж дві таблиці із полями базового
        /// <summary>
        /// Gets or sets table of publications 
        /// </summary>
        public DbSet<Publication> Publications { get; set; }

        /// <summary>
        /// Gets or sets table of pricing
        /// </summary>
        public DbSet<Pricing> Pricings { get; set; }      

        public BookShopContext():base("BookShop")
        {

        }

        //TODO: MAPPING????
        /// <summary>
        /// Created TPC mapping
        /// </summary>
        /// <param name="modelBuilder">object of DbModelBuilder</param>    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Map(m => 
            {
                m.MapInheritedProperties();
                m.ToTable("Books");
            });

            modelBuilder.Entity<Magazine>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Magazines");
            });

            modelBuilder.Entity<Publication>()
                        .Property(p => p.PublicationId)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Pricing>().Map(m =>
            {                
                m.Properties(p => new { p.PublicationId, p.Price });
                m.ToTable("PricingOfPublication");
            });

            
            modelBuilder.Entity<Pricing>().HasKey<int>(p => p.PublicationId);

            modelBuilder.Entity<Publication>()
                        .HasOptional(p => p.Pricing)
                        .WithRequired(p => p.Publication);

            modelBuilder.Entity<Pricing>().Property(p => p.Price)
                                          .HasColumnName("Price")
                                          .HasColumnOrder(3)
                                          .HasColumnType("float")                                          
                                          .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
