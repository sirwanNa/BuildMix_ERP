namespace Firm.Domain.Entities.Commodity
{
    /// <summary>
    /// مواد اولیه تشکیل دهنده محصولات
    /// </summary>
    public class Material:BaseEntity
    {
        /// <summary>
        /// کد محصول اصلی
        /// </summary>
        public Guid MainProductId { get; set; }
        /// <summary>
        /// محصول اصلی
        /// </summary>
        public virtual Product? MainProduct { get; set; }
        /// <summary>
        /// کد محصول فرعی
        /// </summary>
        public Guid SubProductId { get; set; }
        /// <summary>
        /// محصول فرعی
        /// </summary>
        public virtual Product? SubProduct { get; set; }
        /// <summary>
        /// مقدار مصرف
        /// </summary>
        public float Amount { get; set; }
    }
}
