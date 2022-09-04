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

        public async Task<List<Catalog>> GetAllAsync()
        {
            var result = await _cache.GetAsync<List<Catalog>>(CATALOGS_CACHE_KEY);

            if (result != null)
                return result;

            var response = await _provider.GetAllAsync();
            var mapResult = _mapper.Map<CatalogDbo, Catalog>(response).ToList();
            await _cache.SetAsync(CATALOGS_CACHE_KEY, mapResult);

            return mapResult;
        }

        public Task AddAsync(Catalog catalog)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Catalog catalog, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task СlearCacheAsync()
        {
            await _cache.RemoveAsync(CATALOGS_CACHE_KEY);
        }
    }
}