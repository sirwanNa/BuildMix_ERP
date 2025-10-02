using Firm.Application.DTOs.Common;
using Firm.Application.DTOs.Common.Queries;
using Firm.Application.Interfaces.IData;
using Firm.Application.Interfaces.IServices.Common;
using Firm.Infrastructure.Repositories;

namespace Firm.Infrastructure.Services.Common
{
    public class UnitService(IUnitOfWork unitOfWork) : BaseRepository(unitOfWork), IUnitService
    {
        public Task<int> CreateUnitAsync(UnitDTO model, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteUnitAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UnitDTO> GetUnitAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UnitListDTO> GetUnitsListAsync(UnitQueryDTO filterModel)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateUnitAsync(UnitDTO model, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
 