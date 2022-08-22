using Chilling.Goods.Api.Core.Interfaces;
using Chilling.Goods.Api.Core.Models;

namespace Chilling.Goods.Api.Core.Services
{
    public class CatalogService : ICatalogService
    {
        public Task<List<Catalog>> GetAllAsync()
        {
            throw new NotImplementedException();
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
    }
}