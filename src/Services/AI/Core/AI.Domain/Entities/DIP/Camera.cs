using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace AI.Domain.Entities.DIP
{
    /// <summary>
    /// دوربین
    /// </summary>
    public class Camera:BaseEntity
    {
        /// <summary>
        /// سریال دوربین
        /// </summary>
        public required string CameraSerial {  get; set; }
        /// <summary>
        ///   کد استقرار کارخانه دوربین
        /// </summary>
        public required Guid PersonId { get; set; }
    }
}
