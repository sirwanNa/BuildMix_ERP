using Firm.Domain.Entities.Commodity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Commodity
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasOne(p => p.Unit)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.UnitId)
                .IsRequired(true);

            builder.Property(p => p.Title).IsRequired(true).IsUnicode(true).HasMaxLength(500);

            builder.HasIndex(index => new { index.Title });
        }
    }
}
