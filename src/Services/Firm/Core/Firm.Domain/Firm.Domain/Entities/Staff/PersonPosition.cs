using Shared.Enums.Firm.Staff;

namespace Firm.Domain.Entities.Staff
{
    public class PersonPosition:BaseEntity
    {
        public PersonType PersonType { get; set; }
    }
}
