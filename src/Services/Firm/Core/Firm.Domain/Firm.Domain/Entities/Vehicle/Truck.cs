using Firm.Domain.Entities.Staff;
using Shared.Enums.Firm.Vehicle;

namespace Firm.Domain.Entities.Vehicle
{
    public class Truck:BaseEntity
    {
        //Title
        public string Title { get; set; }
        public TruckType TruckType { get; set; }
        public string Plate { get; set; }
        public float Weight { get; set; }
        public Guid OwnerId { get; set; }
        public virtual Person? Owner { get; set; }
        public Guid DriverId { get; set; }
        public virtual Person? Driver { get; set; }
    }
}
