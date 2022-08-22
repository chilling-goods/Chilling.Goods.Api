using Chilling.Goods.Api.Data.Models;

namespace Chilling.Goods.Api.Data.Interfaces
{
    public interface ICatalogProvider
    {
        public Task<List<CatalogDbo>> GetAllAsync();

        public Task AddAsync(CatalogDbo catalog);

        public Task UpdateAsync(CatalogDbo catalog, Guid id);

        public Task DeleteAsync(Guid id);

    }
}