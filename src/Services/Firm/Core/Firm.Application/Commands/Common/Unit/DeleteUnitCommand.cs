using Firm.Application.Interfaces.IServices.Common;
using MediatR;

namespace Firm.Application.Commands.Common.Unit
{
    public class DeleteUnitCommand : IRequest<int>
    {
        public Guid Id { get; set; }
    }
    public class DeleteUnitCommandHandler(IUnitService unitService) : IRequestHandler<DeleteUnitCommand, int>
    {
        private readonly IUnitService _unitService = unitService;
        public async Task<int> Handle(DeleteUnitCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitService.DeleteUnitAsync(request.Id, cancellationToken);
            return result;
        }
    }
}
