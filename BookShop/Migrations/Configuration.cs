using System.Data.Entity.Migrations;
using BookShop.Model;

namespace BookShop.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<BookShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookShopContext context)
        {
            //var fantasy = new Genre {Id = 1, Name = "Fantasy"};

            //var author = new Author
            //    {
            //        FullName = "Joanne Rowling",
            //        PenName = "J. K. Rowling",
            //        DateOfBirth = new DateTime(1965, 7, 31).ToUniversalTime()
            //    };

            ////TODO: PublicationId, як зробити.щоб не вказувати?
            //var book = new Book
            //    {
            //        PublicationId = 1,
            //        Title = "Harry Potter and the Philosopher's Stone",
            //        PublicationDate = new DateTime(1997, 6, 26).ToUniversalTime(),
            //        Pages = 223,
       
            //        AuthorOfPublication = author
            //    };
            //book.Genres = new List<Genre>() {fantasy};

            //var magazine = new Magazine
            //    {
            //        PublicationId = 2,
            //        Title = "Time",
            //        PublicationDate = DateTime.Now.ToUniversalTime(),
            //        Pages = 40,
            //        Company = "Time Warner ",
            //        Frequency = 12,
            //        Categories = "News magazine"
            //    };
            //    context.Authors.AddOrUpdate(author);
            //    context.Magazines.AddOrUpdate(magazine);
            //    context.Books.AddOrUpdate(book);
            //    context.Genres.AddOrUpdate(fantasy);

            //    context.SaveChanges();   
        }
    }
}
