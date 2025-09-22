using Firm.Domain.Entities.Staff;

namespace Firm.Domain.Entities.Common
{
    /// <summary>
    /// واحد های اندازگیری
    /// </summary>
    public class Unit:BaseEntity
    {
        /// <summary>
        /// عنوان واحد
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// شناسه واحد والد
        /// </summary>
        public Guid? ParentId { get; set; }
        /// <summary>
        /// واحد والد
        /// </summary>
        public virtual Unit? Parent { get; set; }
        /// <summary>
        /// ضریب تبدیل واحد
        /// </summary>
        public float Conversion { get; set; }
    }
    
}
