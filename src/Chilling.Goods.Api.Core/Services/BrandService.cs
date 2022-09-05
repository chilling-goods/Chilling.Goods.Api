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

    private readonly IBrandProvider _provider;
    private readonly IMapper _mapper;
    private readonly IRedisProvider _cache;

    public BrandService(IBrandProvider brandProvider, IMapper mapper, IRedisProvider redisProvider)
    {
        _provider = brandProvider;
        _mapper = mapper;
        _cache = redisProvider;
    }

    public async Task<IEnumerable<Brand>> GetAllAsync(CancellationToken cancellationToken)
    {
        var result = await _cache.GetAsync<IEnumerable<Brand>>(BRANDS_CACHE_KEY);

        if (result != null)
            return result;

        var response = await _provider.GetAllAsync(cancellationToken);
        var mapResult = _mapper.Map<BrandDbo, Brand>(response).ToList();
        await _cache.SetAsync(BRANDS_CACHE_KEY, mapResult);

        return mapResult;
    }

    public async Task AddAsync(Brand model, CancellationToken cancellationToken)
    {
        var mapResult = _mapper.Map<Brand, BrandDbo>(model);
        await _provider.AddAsync(mapResult, cancellationToken);

        await ClearCacheAsync(cancellationToken);
    }

    public async Task UpdateAsync(Brand model, Guid id, CancellationToken cancellationToken)
    {
        if (!(await _cache.GetAsync<IEnumerable<Brand>>(BRANDS_CACHE_KEY)).Any(x => x.Id == id))
            throw new Exception(); // TODO: Добавить исключение "Бренд с id <> не найден" - 404 

        var mapResult = _mapper.Map<Brand, BrandDbo>(model);

        await _provider.UpdateAsync(mapResult, id, cancellationToken);
        await ClearCacheAsync(cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        if (!(await _cache.GetAsync<IEnumerable<Brand>>(BRANDS_CACHE_KEY)).Any(x => x.Id == id))
            throw new Exception(); // TODO: Добавить исключение "Бренд с id <> не найден" - 404 

        await _provider.DeleteAsync(id, cancellationToken);
        await ClearCacheAsync(cancellationToken);
    }

    public async Task ClearCacheAsync(CancellationToken cancellationToken)
    {
        await _cache.RemoveAsync(BRANDS_CACHE_KEY);

    }
}