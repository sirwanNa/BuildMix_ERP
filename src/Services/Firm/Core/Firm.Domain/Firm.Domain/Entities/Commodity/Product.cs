using Firm.Domain.Entities.Common;

namespace Firm.Domain.Entities.Commodity
{
    public class Product:BaseEntity
    {
        public string Title { get; set; }
        public Guid UnitId { get; set; }
        public virtual Unit? Unit { get; set; }
    }
}
