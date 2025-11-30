using Firm.Application.DTOs.Common;
using Firm.Application.DTOs.Common.Queries;
using Firm.Application.Exceptions;
using Firm.Application.Interfaces.IData;
using Firm.Application.Interfaces.IServices.Common;
using Firm.Domain.Entities.Common;
using Firm.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Firm.Infrastructure.Services.Common
{
    public class UnitService(IUnitOfWork unitOfWork) : BaseRepository(unitOfWork), IUnitService
    {
        public async Task<UnitDTO> GetUnitAsync(Guid id)
        {
            var obj = await GetAsync<Unit>(id);
            return obj == null ? throw new NotFoundException("Unit") : UnitDTO.FromEntity(obj);
        }
        public async Task<UnitListDTO> GetUnitsListAsync(UnitQueryDTO filterModel)
        {
            var query = GetAll<Unit>();
            if (!string.IsNullOrEmpty(filterModel.Title))
            {
                query = query.Where(p => p.Title.Contains(filterModel.Title));
            }
            if (filterModel.ParentId.HasValue)
            {
                query = query.Where(p => p.ParentId == filterModel.ParentId);
            }
            var queryList = await query
                .OrderBy(p => p.Title)
                .Skip(filterModel.PageSize * (filterModel.PageNumber - 1))
                .Take(filterModel.PageSize).ToListAsync();
            throw new NotImplementedException();
        }
        public Task<int> CreateUnitAsync(UnitDTO model, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public Task<int> UpdateUnitAsync(UnitDTO model, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public Task<int> DeleteUnitAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}
 