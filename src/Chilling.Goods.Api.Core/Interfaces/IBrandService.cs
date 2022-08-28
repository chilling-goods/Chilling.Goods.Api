using Chilling.Goods.Api.Core.Models;

namespace Chilling.Goods.Api.Core.Interfaces;

public interface IBrandService
{
    Task<IEnumerable<Brand>> GetBrandsAsync(CancellationToken cancellationToken);
    
    Task AddBradAsync(Brand brand,CancellationToken cancellationToken);

    Task UpdateBrandAsync(Brand brand,CancellationToken cancellationToken);

    Task DeleteBrandAsync(string key, CancellationToken cancellationToken);
}