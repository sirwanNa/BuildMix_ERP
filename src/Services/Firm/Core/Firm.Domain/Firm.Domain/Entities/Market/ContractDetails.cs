using Firm.Domain.Entities.Commodity;

namespace Firm.Domain.Entities.Market
{
    public class ContractDetails : BaseEntity
    {
        public int QTY_Price { get; set; }
        public float Total { get; set; }
        public Guid ContractId { get; set; }
        public virtual Contract? Contract{get;set;}
        public Guid ProductId { get; set; }
        public virtual Product? Product{get; set; }
    }
}
