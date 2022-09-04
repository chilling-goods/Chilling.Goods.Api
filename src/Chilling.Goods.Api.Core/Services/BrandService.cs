using Chilling.Goods.Api.Core.Interfaces;
using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Data.Interfaces;
using Chilling.Goods.Api.Data.Models;
using Chilling.Platform.Mapper.Abstracts;
using Chilling.Platform.Redis;

namespace Chilling.Goods.Api.Core.Services;

public class BrandService : IBrandService
{
    private const string BRANDS_CACHE_KEY = "BRANDS_KEY";

    private readonly IBrandProvider _brandProvider;
    private readonly IMapper _mapper;
    private readonly IRedisProvider _cache;

    public BrandService(IBrandProvider brandProvider, IMapper mapper, IRedisProvider redisProvider)
    {
        _brandProvider = brandProvider;
        _mapper = mapper;
        _cache = redisProvider;
    }

    public async Task<IEnumerable<Brand>> GetAsync(CancellationToken cancellationToken)
    {
        return _mapper.Map<IEnumerable<BrandDbo>, IEnumerable<Brand>>(await _brandProvider.GetAsync(cancellationToken));
    }

    public async Task AddAsync(Brand brand, CancellationToken cancellationToken)
    {
        await _brandProvider.AddAsync(_mapper.Map<Brand, BrandDbo>(brand), cancellationToken);
    }

    public async Task UpdateAsync(Guid id, Brand brand, CancellationToken cancellationToken)
    {
        await _brandProvider.UpdateAsync(id, _mapper.Map<Brand, BrandDbo>(brand), cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        await _brandProvider.DeleteAsync(id, cancellationToken);
    }

    public async Task ClearCacheAsync()
    {
        await _cache.RemoveAsync(BRANDS_CACHE_KEY);

    }
}