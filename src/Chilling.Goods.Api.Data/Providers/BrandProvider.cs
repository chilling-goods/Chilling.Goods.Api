using Chilling.Goods.Api.Data.Interfaces;
using Chilling.Goods.Api.Data.Models;

namespace Chilling.Goods.Api.Data.Providers;

public class BrandProvider: IBrandProvider
{
    public Task<IEnumerable<BrandDbo>> GetBrandsAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task AddBradAsync(BrandDbo brand, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task UpdateBrandAsync(BrandDbo brand, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteBrandAsync(string key, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}