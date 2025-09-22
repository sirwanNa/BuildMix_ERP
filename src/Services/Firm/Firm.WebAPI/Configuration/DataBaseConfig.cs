using System.Reflection.Metadata;
using Firm.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Firm.WebAPI.Configuration
{
    public static class DataBaseConfig
    {
        public static async Task AutoMigration(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<FirmDbContext>();
                context.Database.Migrate();
                //await RunSeeder(context);

            }
            catch (Exception ex)
            {
                // Log or handle migration errors
                Console.WriteLine($"An error occurred during migration: {ex.Message}");
            }
        }

        private static async Task RunSeeder(FirmDbContext context)
        {
            //if (!context.Set<Constant>().Any())
            //{
            //    var seeder = new RealEstateDbSeed(context);
            //    await seeder.SeedAsync();
            //}
               var seeder = new FirmDbSeed(context);
               await seeder.SeedAsync();
        }

        public static IServiceCollection RegisterDbContext(this IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            services.AddDbContext<FirmDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("FirmDbContextConnectionString")));
            return services;
        }
    }
}
