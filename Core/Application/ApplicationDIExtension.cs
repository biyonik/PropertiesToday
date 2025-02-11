using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Application;

public static class ApplicationDIExtension
{
    public static void AddApplicationLayer(this IServiceCollection services)
    {
        services
            .AddAutoMapper(Assembly.GetExecutingAssembly())
            .AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            })
            .AddValidatorsFromAssemblies([Assembly.GetExecutingAssembly()]);
    }
}