using Firm.Domain.Entities.Market;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Market
{
    public class ContractLogConfiguration : IEntityTypeConfiguration<ContractLog>
    {
        public void Configure(EntityTypeBuilder<ContractLog> builder)
        {
            
            builder.HasOne(cl => cl.ContractDetails)
                   .WithMany() 
                   .HasForeignKey(cl => cl.ContractDetailsId)
                   .OnDelete(DeleteBehavior.Cascade) 
                   .IsRequired();           
         
        }
    }
}
