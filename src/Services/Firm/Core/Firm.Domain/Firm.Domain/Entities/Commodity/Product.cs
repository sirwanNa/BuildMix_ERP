using Firm.Domain.Entities.Common;
using Shared.Entities;

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
        public required string Title { get; set; }
        /// <summary>
        /// کد واحد اندازه گیری
        /// </summary>
        public Guid UnitId { get; set; }
        /// <summary>
        /// واحد اندازه گیری
        /// </summary>
        public virtual Unit? Unit { get; set; }
        public virtual ICollection<Material>? MainMaterials { get; set; }
        public virtual ICollection<Material>? SubMaterials { get; set; }
    }
}
