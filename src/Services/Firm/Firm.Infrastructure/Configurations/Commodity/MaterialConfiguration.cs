using Firm.Domain.Entities.Commodity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Commodity
{
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder
                .HasOne(p => p.MainProduct)
                .WithMany(p => p.MainMaterials)
                .HasForeignKey(p => p.MainProductId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder
                .HasOne(p => p.SubProduct)
                .WithMany(p => p.SubMaterials)
                .HasForeignKey(p => p.SubProductId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            builder.HasIndex(index => new { index.MainProductId, index.SubProductId }).IsUnique();
        }
    }
}
