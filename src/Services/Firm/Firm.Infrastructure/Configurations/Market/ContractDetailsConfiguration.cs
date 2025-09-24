using Firm.Domain.Entities.Market;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Market
{
    public class ContractDetailsConfiguration : IEntityTypeConfiguration<ContractDetails>
    {
        public void Configure(EntityTypeBuilder<ContractDetails> builder)
        {
            
            builder.HasOne(cd => cd.Contract)
                   .WithMany(cd=>cd.ContractDetailsList)
                   .HasForeignKey(cd => cd.ContractId)
                   .OnDelete(DeleteBehavior.Cascade) 
                   .IsRequired();

            
            builder.HasOne(cd => cd.Product)
                   .WithMany(cd => cd.ContractDetailsList) 
                   .HasForeignKey(cd => cd.ProductId)
                   .OnDelete(DeleteBehavior.Restrict) 
                   .IsRequired();         
         
            
            builder.HasIndex(cd => new { cd.ContractId,cd.ProductId }).IsUnique();
        }
    }
}
