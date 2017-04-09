using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                Book book = new Book
                {
                    Title = "Harry Potter and the Philosopher's Stone",
                    PublicationDate = new DateTime(1997, 6, 26).ToUniversalTime(),
                    Pages = 223,
                    Genre = "Fantasy",
                    AuthorOfPublication = author
                };

                Magazine magazine = new Magazine
                {
                    Title = "Time",
                    PublicationDate = DateTime.Now.ToUniversalTime(),
                    Pages = 40,
                    Company = "Time Warner ",
                    Frequency = 12,
                    Categories = "News magazine",
                    Number = 1313
                };
                context.Authors.Add(author);
                context.Magazines.Add(magazine);
                context.Books.Add(book);

                context.SaveChanges();
                Console.WriteLine("OK");
            }
        }
    }
}
