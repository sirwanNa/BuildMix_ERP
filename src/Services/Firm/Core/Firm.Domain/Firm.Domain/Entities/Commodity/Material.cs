namespace Firm.Domain.Entities.Commodity
{
    public class Material:BaseEntity
    {
        public Guid MainProductId { get; set; }
        public virtual Product? MainProduct { get; set; }
        public Guid SubProductId { get; set; }
        public virtual Product? SubProduct { get; set; }
        public float Amount { get; set; }
    }
}
