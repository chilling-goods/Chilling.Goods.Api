using Chilling.Goods.Api.Data.Models;

namespace Chilling.Goods.Api.Data.Interfaces;

public interface IBrandProvider
{
    Task<IEnumerable<BrandDbo>> GetBrandsAsync(CancellationToken cancellationToken);

    Task AddBradAsync(BrandDbo brand,CancellationToken cancellationToken);

    Task UpdateBrandAsync(BrandDbo brand,CancellationToken cancellationToken);

    Task DeleteBrandAsync(string key, CancellationToken cancellationToken);
}