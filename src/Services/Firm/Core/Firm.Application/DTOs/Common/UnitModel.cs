using Firm.Domain.Entities.Common;

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
        public static UnitDTO FromEntity(Unit obj)
        {
            return new UnitDTO 
            {
                Title = obj.Title,
                Rate = obj.Rate, 
                ParentId = obj.ParentId 
            };
        }      
    }
    public class UnitListDTO : BaseModel
    {
        public string? ParentTitle { get; set; }
    //    public static List<UnitListDTO> FromEntity(List<Unit> query)
    //    {
    //        return query.Select(p => new UnitListDTO
    //        {
    //            CreatedDate= p.CreatedDate,
    //            Id= p.Id,
    //            IsDeleted=p.IsDeleted,
    //            ParentTitle=
    //        }).ToList();
    //    }
    }
}
