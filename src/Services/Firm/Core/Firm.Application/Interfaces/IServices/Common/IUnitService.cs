using Firm.Application.DTOs.Common;
using Firm.Application.DTOs.Common.Queries;

namespace Firm.Application.Interfaces.IServices.Common
{
    public interface IUnitService
    {
        Task<UnitDTO> GetUnitAsync(Guid id);
        Task<UnitListDTO> GetUnitsListAsync(UnitQueryDTO filterModel);
        Task<int> CreateUnitAsync(UnitDTO model, CancellationToken cancellationToken);
        Task<int> UpdateUnitAsync(UnitDTO model, CancellationToken cancellationToken);
        Task<int> DeleteUnitAsync(Guid id, CancellationToken cancellationToken);

    }
}
 