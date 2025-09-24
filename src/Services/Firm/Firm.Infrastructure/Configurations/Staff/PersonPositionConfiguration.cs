using Firm.Domain.Entities.Staff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Staff
{
    public class PersonPositionConfiguration : IEntityTypeConfiguration<PersonPosition>
    {
        public void Configure(EntityTypeBuilder<PersonPosition> builder)
        {         
            
            builder.HasOne(pp => pp.Person)
                   .WithMany(pp=>pp.PersonPositions) 
                   .HasForeignKey(pp => pp.PersonId)
                   .OnDelete(DeleteBehavior.Cascade) 
                   .IsRequired();          
          
            builder.HasIndex(pp => new { pp.PersonId, pp.PersonType }).IsUnique();
        }
    }
}
