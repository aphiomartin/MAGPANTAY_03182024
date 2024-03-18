using ItemCatalogue.Api.Domain.Interfaces.Repositories;
using ItemCatalogue.Api.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ItemCatalogue.Api.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                            options.UseInMemoryDatabase(databaseName: "ItemCatalogue"));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
