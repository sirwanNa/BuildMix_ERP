using Shared.Enums.Firm.Staff;

namespace Firm.Domain.Entities.Staff
{
    /// <summary>
    /// نقش های اشخاص
    /// </summary>
    public class PersonPosition:BaseEntity
    {
        public PersonType PersonType { get; set; }
    }
}
