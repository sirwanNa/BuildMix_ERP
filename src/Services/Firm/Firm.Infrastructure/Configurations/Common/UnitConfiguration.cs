using Firm.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Common
{
    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
          
            builder.Property(p => p.Title)
                   .IsRequired(true)
                   .IsUnicode(true)
                   .HasMaxLength(200); 
           
            builder.HasOne(p => p.Parent)
                   .WithMany(p=>p.Units)
                   .HasForeignKey(p => p.ParentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.Title)
                .IsUnicode()
                .HasMaxLength(50);
          
            builder.HasIndex(p => p.Title)
                   .IsUnique(); 
        }
    }
}
