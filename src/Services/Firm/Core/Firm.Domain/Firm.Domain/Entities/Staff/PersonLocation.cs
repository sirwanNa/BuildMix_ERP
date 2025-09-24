using Firm.Domain.Entities.Market;
using Shared.Entities;

namespace Firm.Domain.Entities.Staff
{
    /// <summary>
    /// موقعیت های اشخاص
    /// </summary>
    public class PersonLocation:BaseEntity
    {
        /// <summary>
        /// نام موقعیت
        /// </summary>
        public required string Address { get; set; }
        /// <summary>
        /// فاصله به کیلومتر
        /// </summary>
        public int Distance { get; set; }
        /// <summary>
        /// کد شخص
        /// </summary>
        public Guid PersonId { get; set; }
        /// <summary>
        /// شخص
        /// </summary>
        public virtual Person? Person { get; set; }
        public virtual ICollection<Contract>? Contracts { get; set; }

    }
}
