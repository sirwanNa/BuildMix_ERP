using Firm.Domain.Entities.Staff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Staff
{
    public class PersonLocationConfiguration : IEntityTypeConfiguration<PersonLocation>
    {
        public void Configure(EntityTypeBuilder<PersonLocation> builder)
        {
            builder.HasOne(pl => pl.Person)
               .WithMany(pl => pl.PersonLocations)
               .HasForeignKey(pl => pl.PersonId)
               .OnDelete(DeleteBehavior.Cascade)
               .IsRequired();


            builder.Property(pl => pl.Address)
                   .IsRequired()
                   .IsUnicode(true)
                   .HasMaxLength(1000);          
        
        }
    }
}
