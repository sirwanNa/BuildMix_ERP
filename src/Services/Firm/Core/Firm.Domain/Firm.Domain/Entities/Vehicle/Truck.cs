using Firm.Domain.Entities.Market;
using Firm.Domain.Entities.Staff;
using Shared.Entities;
using Shared.Enums.Firm.Vehicle;

namespace Firm.Domain.Entities.Vehicle
{
    /// <summary>
    /// ماشین آلات
    /// </summary>
    public class Truck:BaseEntity
    {
        /// <summary>
        /// عنوان ماشین
        /// </summary>
        public required string Title { get; set; }
        public TruckType TruckType { get; set; }
        /// <summary>
        /// پلاک
        /// </summary>
        public string? Plate { get; set; }
        /// <summary>
        /// وزن خالی
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// کد مالک
        /// </summary>
        public Guid OwnerId { get; set; }
        public virtual Person? Owner { get; set; }
        /// <summary>
        /// کد راننده
        /// </summary>
        public Guid DriverId { get; set; }
        public virtual Person? Driver { get; set; }
        public virtual ICollection<ContractLogVehicle>? ContractLogVehicles { get; set; }

    }
}
