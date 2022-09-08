using Chilling.Goods.Api.Data.Interfaces;
using Chilling.Goods.Api.Data.Models;

namespace Chilling.Goods.Api.Data.Providers;

public class BrandProvider : IBrandProvider
{
    public async Task<IEnumerable<BrandDbo>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await Task.FromResult(new List<BrandDbo>()
        {
            new BrandDbo()
            {
                Name = "test 1",
                ProductTypes = new List<ProductTypeBrandConventionDbo>()
                {
                    new ProductTypeBrandConventionDbo()
                    {
                        Brand = null,
                        ProductType = new ProductTypeDbo{ Name= "test product type" }
                    }
                }
            },
            new BrandDbo()
            {
                Name = "test 2",
                ProductTypes = new List<ProductTypeBrandConventionDbo>()
                {
                    new ProductTypeBrandConventionDbo()
                    {
                        Brand = null,
                        ProductType = new ProductTypeDbo{ Name= "test product type" }
                    }
                }
            }
        });
    }

    public Task AddAsync(BrandDbo model, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task UpdateAsync(BrandDbo model, Guid id, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}