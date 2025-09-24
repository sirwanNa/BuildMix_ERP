using Firm.Domain.Entities.Staff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firm.Infrastructure.Configurations.Staff
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasOne(p => p.Parent)
               .WithMany(p=>p.ChildrenList)
               .HasForeignKey(p => p.ParentId)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);


            builder.Property(p => p.FirstName)
                   .IsRequired()                  
                   .HasMaxLength(200);
           
            builder.Property(p => p.LastName)
                   .IsRequired(false)
                   .HasMaxLength(200);
            
            builder.Property(p => p.Phone)
                   .IsRequired(false)
                   .HasMaxLength(20);

           
            builder.Property(p => p.Address)
                   .IsRequired(false)
                   .HasMaxLength(500);              
           
        }
    }
}
