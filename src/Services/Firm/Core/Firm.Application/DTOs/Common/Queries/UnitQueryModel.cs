using System.ComponentModel.DataAnnotations;

namespace Firm.Application.DTOs.Common.Queries
{
    public class UnitQueryDTO
    {
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than or equal to 1.")]
        public int PageNumber { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than or equal to 1.")]
        public int PageSize { get; set; }
        public string? Title { get; set; }
        public Guid? ParentId { get; set; }
    }
}
