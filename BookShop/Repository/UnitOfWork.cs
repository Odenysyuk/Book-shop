using System;
using BookShop.Model;

namespace BookShop.Repository
{
    class UnitOfWork : IUnitOfWork
    {
        private BookShopContext context = new BookShopContext();
        private GenericRepository<Book> bookRepository;
        private GenericRepository<Magazine> magazineRepository;
        private GenericRepository<Author> authorRepository;
        private GenericRepository<Genre> genreRepository;

        public GenericRepository<Book> BookRepository
        {
            get
            {
                if (this.bookRepository == null)
                {
                    this.bookRepository = new GenericRepository<Book>(context);
                }
                return bookRepository;
            }
        }

        public GenericRepository<Magazine> MagazineRepository
        {
            get
            {
                if (this.magazineRepository == null)
                {
                    this.magazineRepository = new GenericRepository<Magazine>(context);
                }
                return magazineRepository;
            }
        }

        public GenericRepository<Author> AuthorRepository
        {
            get
            {
                if (this.authorRepository == null)
                {
                    this.authorRepository = new GenericRepository<Author>(context);
                }
                return authorRepository;
            }
        }

        public GenericRepository<Genre> GenreRepository
        {
            get
            {
                if (this.genreRepository == null)
                {
                    this.genreRepository = new GenericRepository<Genre>(context);
                }
                return genreRepository;
            }
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}
