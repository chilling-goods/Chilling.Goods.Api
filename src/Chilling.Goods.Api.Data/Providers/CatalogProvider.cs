using Chilling.Goods.Api.Data.Interfaces;
using Chilling.Goods.Api.Data.Models;

namespace Chilling.Goods.Api.Data.Providers
{
    public class CatalogProvider : ICatalogProvider
    {
        public Task<List<CatalogDbo>> GetAllAsync()
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
                            Brands = new List<BrandDbo> { new BrandDbo { Id = Guid.NewGuid() } }
                        }
                    }
                }
            });
        }
        public Task AddAsync(CatalogDbo catalog)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CatalogDbo catalog, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}