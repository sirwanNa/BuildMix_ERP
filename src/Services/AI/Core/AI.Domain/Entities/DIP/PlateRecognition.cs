using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Domain.Entities.DIP
{
    /// <summary>
    /// تشخیص پلاک
    /// </summary>
    public class PlateRecognition:BaseEntity
    {
        /// <summary>
        /// پلاک
        /// </summary>
        public string? Plate {  get; set; }
        /// <summary>
        /// لاگ تاریخ و ساعت
        /// </summary>
        public DateTime Log {  get; set; }
        /// <summary>
        /// دوربین
        /// </summary>
        public required Guid CameraId {  get; set; }
        public virtual Camera?
            
            Camera { get; set; }
    }
}
