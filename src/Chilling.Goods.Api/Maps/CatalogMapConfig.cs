using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Models;
using Chilling.Platform.Mapper;
using Chilling.Platform.Mapper.Abstracts;

namespace Chilling.Goods.Api.Maps
{
    public class CatalogMapConfig : IMapperConfig
    {
        private readonly IMapper _instance = Mapper.Instance;

        public void AddMaps()
        {
            Mapper.AddMap<Catalog, CatalogVm>((source) => new CatalogVm
            {
                Id = source.Id,
                Name = source.Name,
                ProductTypes = _instance.Map<ProductType, ProductTypeVm>(source.ProductTypes)?.ToList()
            });

            Mapper.AddMap<CatalogVm, Catalog>((source) => new Catalog
            {
                Id = source.Id,
                Name = source.Name,
                ProductTypes = _instance.Map<ProductTypeVm, ProductType>(source.ProductTypes)?.ToList()
            });
        }
    }
}
