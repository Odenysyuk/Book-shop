using System;
using System.Data.Entity;
using BookShop.Model;

namespace BookShop.Repository
{
    /// <summary>
    /// Representation instance of UnitOfWork
    /// </summary>
    class UnitOfWork : IUnitOfWork
    {
        private BookShopContext context = new BookShopContext();
        private bool disposed = false;
        public IGenericRepository<Book> bookRepository;
        public IGenericRepository<Magazine> magazineRepository;
        public IGenericRepository<Author> authorRepository;
        public IGenericRepository<Genre> genreRepository;
        public IGenericRepository<Blog> blogRepository;
        public IGenericRepository<BlogComment> blogCommentRepository;
        public IGenericRepository<Order> orderRepository;
        public IGenericRepository<SubscriptionType> subscriptionType;
        public IGenericRepository<Subscriptions> subscriptionsRepository;

        /// <summary>
        /// Gets repository for working with book
        /// </summary>
        public IGenericRepository<Book> BookRepository
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

        /// <summary>
        /// Gets repository for working with magazine
        /// </summary>
        public IGenericRepository<Magazine> MagazineRepository
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

        /// <summary>
        /// Gets repository for working with author
        /// </summary>
        public IGenericRepository<Author> AuthorRepository
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

        /// <summary>
        /// Gets repository for working with genre
        /// </summary>
        public IGenericRepository<Genre> GenreRepository
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

        /// <summary>
        /// Gets repository for working with blog
        /// </summary>
        public IGenericRepository<Blog> BlogRepository { get; }

        /// <summary>
        /// Gets or sets for working with commentof blog
        /// </summary>
        public IGenericRepository<BlogComment> BlogCommentRepository { get; }

        /// <summary>
        /// Gets or sets for working with order
        /// </summary>
        public IGenericRepository<Order> OrderRepository { get; }

        /// <summary>
        /// Gets or sets for working with type of subscription
        /// </summary>
        public IGenericRepository<SubscriptionType> SubscriptionType { get; }

        /// <summary>
        /// Gets or sets for working with subscriptions
        /// </summary>
        public IGenericRepository<Subscriptions> SubscriptionsRepository { get; }

        /// <summary>
        /// Dispose context`s changes
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Saves context`s changes
        /// </summary>
        public void Save()
        {
            context.SaveChanges();
        }

        /// <summary>
        /// Dispose context`s changes
        /// </summary>
        /// <param name="disposing">Is object disposing</param>
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
