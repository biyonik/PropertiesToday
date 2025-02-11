using Application.Repositories;
using Infrastructure.Contexts;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureDIExtension
{
    public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services)
    {
        return services
            .AddTransient<IPropertyRepository, PropertyRepository>()
            .AddDbContext<ApplicationDbContext>();
    }
}