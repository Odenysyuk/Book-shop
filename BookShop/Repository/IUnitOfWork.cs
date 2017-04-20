using System;

namespace BookShop.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        void Dispose(bool disposing);
    }
}