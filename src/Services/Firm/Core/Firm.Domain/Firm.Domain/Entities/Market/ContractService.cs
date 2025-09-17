using Shared.Enums.Firm.Vehicle;

namespace Firm.Domain.Entities.Market
{
    public class ContractService:BaseEntity
    {
        public TruckType TruckType { get; set; }
        public int QTY_Price { get; set; }
        public Guid ContractId { get; set; }
        public virtual Contract? Contract { get; set; }
    }
}
