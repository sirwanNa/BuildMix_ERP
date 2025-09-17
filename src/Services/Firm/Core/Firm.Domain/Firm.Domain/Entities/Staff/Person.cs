namespace Firm.Domain.Entities.Staff
{
    public class Person:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid? ParentId { get; set; }
        public virtual Person? Parent { get; set; }
    }
}
