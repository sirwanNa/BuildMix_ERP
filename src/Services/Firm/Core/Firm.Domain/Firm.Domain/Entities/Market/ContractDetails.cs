using Firm.Domain.Entities.Commodity;
using Shared.Entities;

namespace Firm.Domain.Entities.Market
{
    /// <summary>
    /// محصولات قرارداد
    /// </summary>
    public class ContractDetails : BaseEntity
    {
        /// <summary>
        /// بهای واحد
        /// </summary>
        public int QTY_Price { get; set; }
        /// <summary>
        /// حجم کل قرارداد
        /// </summary>
        public float Total { get; set; }
        /// <summary>
        /// کد قرارداد
        /// </summary>
        public Guid ContractId { get; set; }
        public virtual Contract? Contract{get;set;}
        /// <summary>
        /// کد محصول
        /// </summary>
        public Guid ProductId { get; set; }
        public virtual Product? Product{get; set; }

    }
}
