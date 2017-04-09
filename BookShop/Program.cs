using BookShop.Model;
using System;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookShopContext())
            {
                Author author = new Author
                {
                    FullName = "Joanne Rowling",
                    PenName = "J. K. Rowling",
                    DateOfBirth = new DateTime(1965, 7, 31).ToUniversalTime()
                };

                //TODO: PublicationId, як зробити.щоб не вказувати?
                Book book = new Book
                {
                    PublicationId = 1,
                    Title = "Harry Potter and the Philosopher's Stone",
                    PublicationDate = new DateTime(1997, 6, 26).ToUniversalTime(),
                    Pages = 223,
                    Genre = "Fantasy",
                    AuthorOfPublication = author
                };

                Magazine magazine = new Magazine
                {
                    PublicationId = 2,
                    Title = "Time",
                    PublicationDate = DateTime.Now.ToUniversalTime(),
                    Pages = 40,
                    Company = "Time Warner ",
                    Frequency = 12,
                    Categories = "News magazine",
                    Printing = 1313
                };
                context.Authors.Add(author);
                context.Publications.Add(magazine);
                context.Publications.Add(book);

                context.SaveChanges();
                Console.WriteLine("OK");
            }
        }
    }
}
