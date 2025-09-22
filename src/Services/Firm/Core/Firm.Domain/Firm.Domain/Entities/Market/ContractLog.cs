namespace Firm.Domain.Entities.Market
{
    /// <summary>
    /// لاگهای قرارداد
    /// </summary>
    public class ContractLog:BaseEntity
    {
        /// <summary>
        /// تاریخ و ساعت
        /// </summary>
        public DateTime Date { get; set; }
        public Guid ContractDetailsId { get; set; }
        /// <summary>
        /// بند قرارداد
        /// </summary>
        public virtual ContractDetails? ContractDetails { get; set; }
    }
}
