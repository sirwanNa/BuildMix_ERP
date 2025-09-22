namespace Firm.Domain.Entities.Staff
{
    /// <summary>
    /// موقعیت های اشخاص
    /// </summary>
    public class PersonAddress:BaseEntity
    {
        /// <summary>
        /// نام موقعیت
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// فاصله به کیلومتر
        /// </summary>
        public int Distance { get; set; }
        /// <summary>
        /// کد شخص
        /// </summary>
        public Guid PersonId { get; set; }
        /// <summary>
        /// شخص
        /// </summary>
        public virtual Person? Person { get; set; }
        
    }
}
