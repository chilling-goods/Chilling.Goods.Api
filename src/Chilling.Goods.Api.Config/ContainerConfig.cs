using Microsoft.Extensions.DependencyInjection;

namespace Chilling.Goods.Api.Config;

public static class ContainerConfig
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        return services;
    }
}