using Firm.Domain.Entities.Market;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Market
{
    public class ContractServiceConfiguration : IEntityTypeConfiguration<ContractService>
    {
        public void Configure(EntityTypeBuilder<ContractService> builder)
        {            
            builder.HasOne(cs => cs.Contract)
                   .WithMany(cs=>cs.ContractServicesList) 
                   .HasForeignKey(cs => cs.ContractId)
                   .OnDelete(DeleteBehavior.Cascade) 
                   .IsRequired();
          
            builder.HasIndex(cs => new { cs.ContractId , cs.TruckType});
        }
    }
}
