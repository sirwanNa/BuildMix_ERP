using Firm.Domain.Entities.Vehicle;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Vehicle
{
    public class TruckConfiguration : IEntityTypeConfiguration<Truck>
    {
        public void Configure(EntityTypeBuilder<Truck> builder)
        {
            builder.HasOne(t => t.Owner)
               .WithMany(t=>t.TruckOwners)
               .HasForeignKey(t => t.OwnerId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            builder.HasOne(t => t.Driver)
                   .WithMany(t=>t.TruckDrivers)
                   .HasForeignKey(t => t.DriverId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();

            builder.Property(t => t.Title)
                   .IsRequired()
                   .IsUnicode(true)
                   .HasMaxLength(200);

           
            builder.Property(t => t.Plate)
                   .IsUnicode(false)
                   .HasMaxLength(20);        
                     
            builder.HasIndex(t => new { t.OwnerId, t.DriverId, t.Plate }).IsUnique(false);
           
        }
    }
}
