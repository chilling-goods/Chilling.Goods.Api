using Chilling.Goods.Api.Core.Interfaces;
using Chilling.Goods.Api.Core.Models;

namespace Chilling.Goods.Api.Core.Services;

public class BrandService: IBrandService
{
    public Task<IEnumerable<Brand>> GetBrandsAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task AddBradAsync(Brand brand, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task UpdateBrandAsync(Brand brand, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteBrandAsync(string key, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}