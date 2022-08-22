using Chilling.Goods.Api.Core.Models;

namespace Chilling.Goods.Api.Core.Interfaces
{
    public interface ICatalogService
    {
        public Task<List<Catalog>> GetAllAsync();

        public Task AddAsync(Catalog catalog);

        public Task UpdateAsync(Catalog catalog, Guid id);

        public Task DeleteAsync(Guid id);
    }
}