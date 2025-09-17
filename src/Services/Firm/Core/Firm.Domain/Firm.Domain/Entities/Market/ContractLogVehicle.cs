using Firm.Domain.Entities.Vehicle;

namespace Firm.Domain.Entities.Market
{
    public class ContractLogVehicle:BaseEntity
    {
        public Guid ContractLogId { get; set; }
        public virtual ContractLog? ContractLog { get; set; }
        public Guid TruckId { get; set; }
        public virtual Truck? Truck { get; set; }   
    }
}
