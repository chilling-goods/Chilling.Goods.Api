using Chilling.Goods.Api.Core.Interfaces;
using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Data.Interfaces;
using Chilling.Goods.Api.Data.Models;
using Chilling.Platform.Mapper.Abstracts;
using Chilling.Platform.Redis;

namespace Chilling.Goods.Api.Core.Services
{
    public class CatalogService : ICatalogService
    {
        private const string CATALOGS_CACHE_KEY = "CATALOGS_KEY";

        private readonly IMapper _mapper;
        private readonly ICatalogProvider _provider;
        private readonly IRedisProvider _cache;

        /// <summary>
        /// Контроллер
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="provider"></param>
        /// <param name="cache"></param>
        public CatalogService(IMapper mapper, ICatalogProvider provider, IRedisProvider cache)
        {
            _provider = provider;
            _cache = cache;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Catalog>> GetAllAsync(CancellationToken cancellationToken)
        {
            var result = await _cache.GetAsync<IEnumerable<Catalog>>(CATALOGS_CACHE_KEY);

            if (result != null)
                return result;

            var response = await _provider.GetAllAsync(cancellationToken);
            var mapResult = _mapper.Map<CatalogDbo, Catalog>(response).ToList();
            await _cache.SetAsync(CATALOGS_CACHE_KEY, mapResult);

            return mapResult;
        }

        public async Task AddAsync(Catalog model, CancellationToken cancellationToken)
        {
            var mapResult = _mapper.Map<Catalog, CatalogDbo>(model);
            await _provider.AddAsync(mapResult, cancellationToken);

            await СlearCacheAsync(cancellationToken);
        }

        public async Task UpdateAsync(Catalog model, Guid id, CancellationToken cancellationToken)
        {
            if (!(await _cache.GetAsync<IEnumerable<Catalog>>(CATALOGS_CACHE_KEY)).Any(x => x.Id == id))
                throw new Exception(); // TODO: Добавить исключение "Каталог с id <> не найден" - 404 

            var mapResult = _mapper.Map<Catalog, CatalogDbo>(model);
            await _provider.UpdateAsync(mapResult, id, cancellationToken);

            await СlearCacheAsync(cancellationToken);
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            if (!(await _cache.GetAsync<IEnumerable<Catalog>>(CATALOGS_CACHE_KEY)).Any(x => x.Id == id))
                throw new Exception(); // TODO: Добавить исключение "Каталог с id <> не найден" - 404 

            await _provider.DeleteAsync(id, cancellationToken);
            await СlearCacheAsync(cancellationToken);
        }

        public async Task СlearCacheAsync(CancellationToken cancellationToken)
        {
            await _cache.RemoveAsync(CATALOGS_CACHE_KEY);
        }
    }
}