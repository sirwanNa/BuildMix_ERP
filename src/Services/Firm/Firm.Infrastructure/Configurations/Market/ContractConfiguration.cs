using Firm.Domain.Entities.Market;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Market
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasOne(c => c.Factory)
               .WithMany(c => c.Contracts)
               .HasForeignKey(c => c.FactoryId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();
          
            builder.HasOne(c => c.PersonAddress)
                   .WithMany() 
                   .HasForeignKey(c => c.PersonAddressId)
                   .OnDelete(DeleteBehavior.Restrict) 
                   .IsRequired();
           
        
            //builder.HasIndex(c => new { c.FactoryId, c.PersonAddressId });
        }
    }
}
