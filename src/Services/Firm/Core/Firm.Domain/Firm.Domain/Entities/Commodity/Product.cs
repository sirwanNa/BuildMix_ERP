using Firm.Domain.Entities.Common;

namespace Firm.Domain.Entities.Commodity
{
    /// <summary>
    /// محصولات
    /// </summary>
    public class Product:BaseEntity
    {
        /// <summary>
        /// عنوان محصول
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// کد واحد اندازه گیری
        /// </summary>
        public Guid UnitId { get; set; }
        /// <summary>
        /// واحد اندازه گیری
        /// </summary>
        public virtual Unit? Unit { get; set; }
    }
}
