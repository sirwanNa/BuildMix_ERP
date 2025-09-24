using Firm.Domain.Entities.Market;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Market
{
    public class ContractLogVehicleConfiguration : IEntityTypeConfiguration<ContractLogVehicle>
    {
        public void Configure(EntityTypeBuilder<ContractLogVehicle> builder)
        {
           
            builder.HasOne(clv => clv.ContractDetails)
                   .WithMany(clv=>clv.ContractLogVehicles) 
                   .HasForeignKey(clv => clv.ContractDetailsId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();
            
            builder.HasOne(clv => clv.Truck)
                   .WithMany(clv => clv.ContractLogVehicles) 
                   .HasForeignKey(clv => clv.TruckId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();          
       
            builder.HasIndex(clv => new { clv.ContractDetailsId,clv.TruckId });
        }
    }
}
