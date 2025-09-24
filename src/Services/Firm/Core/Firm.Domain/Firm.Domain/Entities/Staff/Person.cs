using Firm.Domain.Entities.Market;
using Firm.Domain.Entities.Vehicle;
using Shared.Entities;

namespace Firm.Domain.Entities.Staff
{
    /// <summary>
    /// اشخاص شامل راننده مالک ماشین آلات مشتریان فروشندگان کارخانه
    /// </summary>
    public class Person:BaseEntity
    {
        /// <summary>
        /// نانم شرکت/نام کوچک
        /// </summary>
        public required string FirstName { get; set; }
        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// تلفن
        /// </summary>
        public string? Phone {  get; set; }
        /// <summary>
        /// آدرس
        /// </summary>
        public string? Address {  get; set; }
        /// <summary>
        /// شناسه والد شخص
        /// </summary>
        public Guid? ParentId { get; set; }
        /// <summary>
        /// شخص والد
        /// </summary>
        public virtual Person? Parent { get; set; }
        public virtual ICollection<Contract>? Contracts { get; set; }
        public virtual ICollection<Person>? ChildrenList { get; set; }
        public virtual ICollection<PersonLocation>? PersonLocations { get; set; }
        public virtual ICollection<PersonPosition>? PersonPositions { get; set; }
        public virtual ICollection<Truck>? TruckOwners { get; set; }
        public virtual ICollection<Truck>? TruckDrivers { get; set; } 
    }
}
