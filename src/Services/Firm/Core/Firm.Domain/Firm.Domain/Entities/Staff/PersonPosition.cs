using Shared.Enums.Firm.Staff;

namespace Firm.Domain.Entities.Staff
{
    /// <summary>
    /// نقش های اشخاص
    /// </summary>
    public class PersonPosition:BaseEntity
    {
        /// <summary>
        /// توع شخص
        /// </summary>
        public PersonType PersonType { get; set; }
        /// <summary>
        /// کد شخص
        /// </summary>
        public Guid PersonId { get; set; }
        public virtual Person? Person { get; set; }
    }
}
