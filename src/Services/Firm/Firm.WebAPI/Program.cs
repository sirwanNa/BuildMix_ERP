using Firm.WebAPI.Configuration;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var reactAppUrl = builder.Configuration["AllowedOrigins:ReactApp"];

builder.Services.AddOpenApi()
    .RegisterDbContext()
    .RegisterRepositories()
    .ConfigureMediatR("Alfkanz.Application")
    //.ConfigureAutoMapper()
    .ConfigureGlobalFilters()
    .RegisterJWTToken(builder)
    .AddCors(options =>
    {
        options.AddPolicy("AllowReactApp",
            policy =>
            {
                // React dev server
                if (!string.IsNullOrEmpty(reactAppUrl))
                {
                    policy.WithOrigins(reactAppUrl)
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                }

            });
    }); 

builder.Host.UseSerilog((context, services, configuration) =>
{
    configuration.ReadFrom.Configuration(context.Configuration);
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
