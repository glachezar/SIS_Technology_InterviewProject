using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces;
using Infrastructure.Dapper;
using Infrastructure.Dapper.Repositories;

namespace Infrastructure;

public static class DI
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<DbContext>();
        services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));

        return services;
    }
}