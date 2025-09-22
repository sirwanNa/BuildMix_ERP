using Firm.Domain.Entities.Staff;
using Shared.Enums.Firm.Market;

namespace Firm.Domain.Entities.Market
{
    /// <summary>
    /// قرارداد
    /// </summary>
    public class Contract:BaseEntity
    {

        public ContractType ContractType { get; set; }
        /// <summary>
        /// تاریخ و ساعت
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// کارخانه
        /// </summary>
        public Guid FactoryId { get; set; }
        public virtual Person? Factory { get; set; }
        /// <summary>
        /// کد موقعیت طرف قرارداد
        /// </summary>
        public Guid PersonAddressId { get; set; }
        public virtual PersonAddress? PersonAddress { get; set; }   
    }
}
