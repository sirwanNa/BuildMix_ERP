namespace Firm.Domain.Entities.Staff
{
    public class PersonAddress:BaseEntity
    {
        public string Location { get; set; }
        public int Distance { get; set; }
        public Guid PersonId { get; set; }
        public virtual Person? Person { get; set; }
        
    }
}
