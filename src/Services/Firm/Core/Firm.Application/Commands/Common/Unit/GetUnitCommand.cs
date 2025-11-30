using Firm.Application.DTOs.Common;
using Firm.Application.Interfaces.IServices.Common;
using MediatR;

namespace Firm.Application.Commands.Common.Unit
{
    public class GetUnitCommand : IRequest<UnitDTO>
    {
        public Guid Id { get; set; }
    }
    public class GetUnitCommandHandler(IUnitService unitService) : IRequestHandler<GetUnitCommand, UnitDTO>
    {
        private readonly IUnitService _unitService = unitService;

        public async Task<UnitDTO> Handle(GetUnitCommand request, CancellationToken cancellationToken)
        {
            var model = await _unitService.GetUnitAsync(request.Id);
            return model;
        }
    }
}
