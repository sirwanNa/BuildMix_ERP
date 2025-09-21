using Microsoft.EntityFrameworkCore;

namespace Firm.Application.Interfaces.IData
{
    public interface IUnitOfWork
    {
        DbContext Context { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
