using Firm.Application.DTOs.Common;
using Firm.Application.Interfaces.IServices.Common;
using MediatR;

namespace Firm.Application.Commands.Common.Unit
{
    public class CreateUnitCommand : IRequest<int>
    {
        public required UnitDTO Model { get; set; }
    }
    public class CreateUnitCommandHandler(IUnitService unitService) : IRequestHandler<CreateUnitCommand, int>
    {
        private readonly IUnitService _unitService = unitService;
        public async Task<int> Handle(CreateUnitCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitService.CreateUnitAsync(request.Model, cancellationToken);
            return result;
        }
    }
}
