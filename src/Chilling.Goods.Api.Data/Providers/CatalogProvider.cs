using Chilling.Goods.Api.Data.Interfaces;
using Chilling.Goods.Api.Data.Models;

namespace Chilling.Goods.Api.Data.Providers
{
    public class CatalogProvider : ICatalogProvider
    {
        public Task<List<CatalogDbo>> GetAllAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(new List<CatalogDbo>()
            {
                new CatalogDbo
                {
                    Name = "Test1",
                    Id = Guid.NewGuid(),
                    ProductTypes = new List<ProductTypeDbo>
                    {
                        new ProductTypeDbo
                        {
                            Name = "Кальян",
                            IsDisplay = true,
                        }
                    }
                }
            });
        }
        public Task AddAsync(CatalogDbo model, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CatalogDbo model, Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}