using Microsoft.EntityFrameworkCore;
using Ravi.PieShop.Data;

namespace Ravi.PieShop.Repositories
{
    public abstract class RepositoryBase<TContext> : IDisposable where TContext : DbContext
    {
        protected readonly TContext _context;
        private bool _disposed;

        protected RepositoryBase(IDbContextFactory<TContext> appDbContextFactory)
        {
            _context = appDbContextFactory.CreateDbContext();
            if (_context == null)
            {
                throw new InvalidOperationException("Failed to create DbContext.");
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}