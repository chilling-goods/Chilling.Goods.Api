using Chilling.Goods.Api.Data.Interfaces;
using Chilling.Goods.Api.Data.Models;

namespace Chilling.Goods.Api.Data.Providers
{
    public class CatalogProvider : ICatalogProvider
    {
        public Task AddAsync(CatalogDbo catalog)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CatalogDbo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CatalogDbo catalog, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}