using System;
using BookShop.Model;

namespace BookShop.Repository
{
    /// <summary>
    /// Represents an interface for unit of work
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Gets repository for working with book
        /// </summary>
        IGenericRepository<Book> BookRepository { get; }

        /// <summary>
        /// Gets repository for working with magazine
        /// </summary>
        IGenericRepository<Magazine> MagazineRepository { get; }

        /// <summary>
        /// Gets repository for working with author
        /// </summary>
        IGenericRepository<Author> AuthorRepository { get; }

        /// <summary>
        /// Gets repository for working with genre
        /// </summary>
        IGenericRepository<Genre> GenreRepository { get; }

        /// <summary>
        /// Gets repository for working with blog
        /// </summary>
        IGenericRepository<Blog> BlogRepository { get; }

        /// <summary>
        /// Gets or sets for working with commentof blog
        /// </summary>
        IGenericRepository<BlogComment> BlogCommentRepository { get; }

        /// <summary>
        /// Gets or sets for working with order
        /// </summary>
        IGenericRepository<Order> OrderRepository { get; }

        /// <summary>
        /// Gets or sets for working with type of subscription
        /// </summary>
        IGenericRepository<SubscriptionType> SubscriptionType { get; }

        /// <summary>
        /// Gets or sets for working with subscriptions
        /// </summary>
        IGenericRepository<Subscriptions> SubscriptionsRepository { get; }

        /// <summary>
        /// Saves context`s changes
        /// </summary>
        void Save();

        /// <summary>
        /// Dispose context`s changes
        /// </summary>
        /// <param name="disposing">Is object disposing</param>
        void Dispose(bool disposing);
    }
}