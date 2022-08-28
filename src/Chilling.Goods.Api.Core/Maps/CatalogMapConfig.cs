using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Data.Models;
using Chilling.Platform.Mapper;
using Chilling.Platform.Mapper.Abstracts;

namespace Chilling.Goods.Api.Core.Maps
{
    public class CatalogMapConfig : IMapperConfig
    {
        private readonly IMapper _instance = Mapper.Instance;

        public void AddMaps()
        {
            Mapper.AddMap<CatalogDbo, Catalog>((source) => new Catalog
            {
                Id = source.Id,
                Name = source.Name,
                ProductTypes = source.ProductTypes != null
                    ? _instance.Map<ProductTypeDbo, ProductType>(source.ProductTypes).ToList()
                    : null
            });

            Mapper.AddMap<Catalog, CatalogDbo>((source) => new CatalogDbo
            {
                Id = source.Id,
                Name = source.Name,
                ProductTypes = source.ProductTypes != null
                    ? _instance.Map<ProductType, ProductTypeDbo>(source.ProductTypes).ToList()
                    : null
            });
        }
    }
}
