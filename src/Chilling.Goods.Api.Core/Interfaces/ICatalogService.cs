using Chilling.Goods.Api.Core.Models;

namespace Chilling.Goods.Api.Core.Interfaces
{
    public interface ICatalogService
    {
        public Task<IEnumerable<Catalog>> GetAllAsync(CancellationToken cancellationToken);

        public Task AddAsync(Catalog model, CancellationToken cancellationToken);

        public Task UpdateAsync(Catalog model, Guid id, CancellationToken cancellationToken);

        public Task DeleteAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Очистка кеша
        /// </summary>
        /// <returns></returns>
        Task СlearCacheAsync(CancellationToken cancellationToken);
    }
}