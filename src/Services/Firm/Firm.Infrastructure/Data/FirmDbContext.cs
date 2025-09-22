using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Firm.Infrastructure.Data
{
    public class FirmDbContext:DbContext
    {
        public FirmDbContext(DbContextOptions<FirmDbContext> options) : base(options)
        {

        }
        public FirmDbContext() : base()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("firm");
            base.OnModelCreating(modelBuilder);
            var assemly_Domain = Assembly.Load(new AssemblyName("Firm.Domain"));
            EntityHelper.LoadEntities(assemly_Domain, modelBuilder, "Firm.Domain.Entities");
            var assemly_Infrastructure = Assembly.Load(new AssemblyName("Firm.Infrastructure"));
            EntityHelper.LoadConfigs(modelBuilder, assemly_Infrastructure, "Firm.Infrastructure.Configurations");
        }
    }
}
