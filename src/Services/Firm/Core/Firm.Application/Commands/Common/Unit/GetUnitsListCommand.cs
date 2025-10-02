using Firm.Application.DTOs.Common;
using Firm.Application.DTOs.Common.Queries;
using Firm.Application.Interfaces.IServices.Common;
using MediatR;

namespace Firm.Application.Commands.Common.Unit
{
    public class GetUnitsListCommand : IRequest<UnitListDTO>
    {
        public required UnitQueryDTO QueryModel { get; set; }
    }
    public class GetConstantsListCommandHandler(IUnitService unitService) : IRequestHandler<GetUnitsListCommand, UnitListDTO>
    {
        private readonly IUnitService _unitService = unitService;

        public async Task<UnitListDTO> Handle(GetUnitsListCommand request, CancellationToken cancellationToken)
        {
            var model = await _unitService.GetUnitsListAsync(request.QueryModel);
            return model;
        }
    }
}
