using Shared.Enums.Firm.Vehicle;

namespace Firm.Domain.Entities.Market
{
    /// <summary>
    /// سرویس های قرارداد
    /// </summary>
    public class ContractService:BaseEntity
    {
        /// <summary>
        /// نوع ماشین
        /// </summary>
        public TruckType TruckType { get; set; }
        /// <summary>
        /// بهای واحد
        /// </summary>
        public int QTY_Price { get; set; }
        /// <summary>
        /// کد قرارداد
        /// </summary>
        public Guid ContractId { get; set; }
        public virtual Contract? Contract { get; set; }
    }
}
