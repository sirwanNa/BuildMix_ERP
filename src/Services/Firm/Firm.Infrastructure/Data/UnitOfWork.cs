using Firm.Application.Interfaces.IData;
using Microsoft.EntityFrameworkCore;

namespace Firm.Infrastructure.Data
{
    public class UnitOfWork(FirmDbContext context) : IUnitOfWork, IDisposable
    {
        private bool _disposed = false;
        public required DbContext Context { get; set; } = context;

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await Context.SaveChangesAsync(cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context?.Dispose();
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
