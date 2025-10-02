namespace Firm.Application.DTOs.Common
{
    public class BaseUnitDTO : BaseModel
    {
        public required string Title { get; set; }
        public float Rate { get; set; }
    }
    public class UnitDTO : BaseUnitDTO
    {
        public Guid? ParentId { get; set; }
    }
    public class UnitListDTO : BaseModel
    {
        public string? ParentTitle { get; set; }
    }
}
