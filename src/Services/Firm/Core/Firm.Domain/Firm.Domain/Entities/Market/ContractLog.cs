namespace Firm.Domain.Entities.Market
{
    public class ContractLog:BaseEntity
    {
        public DateTime Date { get; set; }
        public float FullWeight { get; set; } 
        public Guid ContractDetailsId { get; set; }
        public virtual ContractDetails? ContractDetails { get; set; }
    }
}
