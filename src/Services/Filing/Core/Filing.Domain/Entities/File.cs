using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filing.Domain.Entities
{
    /// <summary>
    /// فایل ها
    /// </summary>
    public class File:BaseEntity
    {
        /// <summary>
        /// نام فایل
        /// </summary>
        public required string FileName {  get; set; }
        /// <summary>
        /// نام مایکرو سرویس
        /// </summary>
        public required byte[] FileContent {  get; set; }
        /// <summary>
        /// فایل Thumbnail
        /// </summary>
        public required byte[] FileThumbnail { get; set; }
        /// <summary>
        /// اندازه فایل
        /// </summary>
        public required int FileSize {  get; set; }
        /// <summary>
        /// تاریخ و ساعت ذخیره
        /// </summary>
        public required DateTime LogDateTime { get; set; }

    }
}
