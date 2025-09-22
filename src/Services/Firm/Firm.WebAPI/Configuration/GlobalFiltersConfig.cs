using Firm.WebAPI.Filters;

namespace Firm.WebAPI.Configuration
{
    public static class GlobalFiltersConfig
    {
        public static IServiceCollection ConfigureGlobalFilters(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add<GlobalExceptionFilter>();
            });
            return services;
        }
    }
}
