using Firm.Domain.Entities.Vehicle;

namespace Firm.Domain.Entities.Market
{
    /// <summary>
    /// ماشین آلات لاگ قرارداد
    /// </summary>
    public class ContractLogVehicle:BaseEntity
    {
        /// <summary>
        /// وزن پر
        /// </summary>
        public float FullWeight { get; set; }
        /// <summary>
        /// کد لاگ قرارداد
        /// </summary>
        public Guid ContractLogId { get; set; }
        public virtual ContractLog? ContractLog { get; set; }
        /// <summary>
        /// ماشین
        /// </summary>
        public Guid TruckId { get; set; }
        public virtual Truck? Truck { get; set; }

    }
}
