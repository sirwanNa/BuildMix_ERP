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
    }
}
