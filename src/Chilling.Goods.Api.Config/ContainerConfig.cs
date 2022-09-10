using Chilling.Goods.Api.Core.Interfaces;
using Chilling.Goods.Api.Core.Services;
using Chilling.Goods.Api.Data.Interfaces;
using Chilling.Goods.Api.Data.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Chilling.Goods.Api.Config;

public static class ContainerConfig
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ICatalogProvider, CatalogProvider>();
        services.AddScoped<ICatalogService, CatalogService>();

        services.AddScoped<IBrandService, BrandService>();
        services.AddScoped<IBrandProvider, BrandProvider>();

        services.AddScoped<IStoreService, StoreService>();
        services.AddScoped<IStoreProvider, StoreProvider>();

        return services;
    }
}