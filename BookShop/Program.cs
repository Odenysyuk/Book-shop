using BookShop.Model;
using System;
using System.Linq;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OK");
            var dd = new BookShopContext();
            var dddd = dd.Books.Select(i => i).ToList();
        }
    }
}
