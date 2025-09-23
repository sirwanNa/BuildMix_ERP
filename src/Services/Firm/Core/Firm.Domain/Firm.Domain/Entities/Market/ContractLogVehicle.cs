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
        /// کد بند قرارداد
        /// </summary>
        public Guid ContractDetailsId { get; set; }
        public virtual ContractDetails? ContractDetails { get; set; }
        /// <summary>
        /// ماشین
        /// </summary>
        public Guid TruckId { get; set; }
        public virtual Truck? Truck { get; set; }

    }
}
