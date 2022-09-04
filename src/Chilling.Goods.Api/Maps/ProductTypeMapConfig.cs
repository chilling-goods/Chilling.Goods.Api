using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Models;
using Chilling.Platform.Mapper;
using Chilling.Platform.Mapper.Abstracts;

namespace Chilling.Goods.Api.Core.Maps
{
    public class ProductTypeMapConfig : IMapperConfig
    {
        private readonly IMapper _instance = Mapper.Instance;
        public void AddMaps()
        {
            Mapper.AddMap<ProductType, ProductTypeVm>((source) => new ProductTypeVm
            {
                Id = source.Id,
                Name = source.Name,
                IsDisplay = source.IsDisplay,
                Brands = _instance.Map<Brand, BrandVm>(source.Brands)?.ToList()
            });

            Mapper.AddMap<ProductTypeVm, ProductType>((source) => new ProductType
            {
                Id = source.Id,
                Name = source.Name,
                IsDisplay = source.IsDisplay,
                Brands = _instance.Map<BrandVm, Brand>(source.Brands)?.ToList()
            });
        }
    }
}
