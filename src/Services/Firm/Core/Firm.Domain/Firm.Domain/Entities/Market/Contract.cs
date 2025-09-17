using Firm.Domain.Entities.Staff;
using Shared.Enums.Firm.Market;

namespace Firm.Domain.Entities.Market
{
    public class Contract:BaseEntity
    {
        public ContractType ContractType { get; set; }
        public DateTime Date { get; set; }
        public Guid PersonId { get; set; }
        public virtual Person? Person { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Person? Company { get; set; }
        public Guid PersonAddressId { get; set; }
        public virtual PersonAddress? PersonAddress { get; set; }   
    }
}
