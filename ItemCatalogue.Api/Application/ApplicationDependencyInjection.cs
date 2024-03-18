using ItemCatalogue.Api.Application.Implementations;
using ItemCatalogue.Api.Application.Interfaces;

namespace ItemCatalogue.Api.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICatalogueService, CatalogueService>();

            return services;
        }
    }
}
