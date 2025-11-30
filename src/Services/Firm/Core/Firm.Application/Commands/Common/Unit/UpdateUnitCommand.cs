using Firm.Application.DTOs.Common;
using Firm.Application.Interfaces.IServices.Common;
using MediatR;

namespace Firm.Application.Commands.Common.Unit
{
    public class UpdateUnitCommand : IRequest<int>
    {
        public required UnitDTO Model { get; set; }
    }
    public class UpdateUnitCommandHandler(IUnitService unitService) : IRequestHandler<UpdateUnitCommand, int>
    {
        private readonly IUnitService _unitService = unitService;
        public async Task<int> Handle(UpdateUnitCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitService.UpdateUnitAsync(request.Model, cancellationToken);
            return result;
        }
    }
}
