using Chilling.Goods.Api.Data.Models;

namespace Chilling.Goods.Api.Data.Interfaces
{
    public interface ICatalogProvider
    {
        public Task<List<CatalogDbo>> GetAllAsync(CancellationToken cancellationToken);

        public Task AddAsync(CatalogDbo model, CancellationToken cancellationToken);

        public Task UpdateAsync(CatalogDbo model, Guid id, CancellationToken cancellationToken);

        public Task DeleteAsync(Guid id, CancellationToken cancellationToken);

    }
}