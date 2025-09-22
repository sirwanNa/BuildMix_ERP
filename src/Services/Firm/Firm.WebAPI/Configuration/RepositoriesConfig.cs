using Firm.Application.Interfaces.IData;
using Firm.Infrastructure.Data;

namespace Firm.WebAPI.Configuration
{
    public static class RepositoriesConfig
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IConstantRepository, ConstantRepository>();
            //services.AddScoped<IPropertyInventoryRepository, PropertyInventoryRepository>();
            //services.AddScoped<IArticleRepository, ArticleRepository>();
            //services.AddScoped<IContactRepository, ContactRepository>();
            return services;
        }
    }
}
