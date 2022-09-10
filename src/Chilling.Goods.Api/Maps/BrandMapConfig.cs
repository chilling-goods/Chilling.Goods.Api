using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Models;
using Chilling.Platform.Mapper;

namespace Chilling.Goods.Api.Maps
{
    public class BrandMapConfig : IMapperConfig
    {
        private readonly IMapper _instance = Mapper.Instance;

        public void AddMaps()
        {
            Mapper.AddMap<Brand, BrandVm>((source) => new BrandVm
            {
                Id = source.Id,
                Name = source.Name,
                ProductTypes = _instance.Map<ProductType, ProductTypeVm>(source.ProductTypes)?.ToList()
            });

            Mapper.AddMap<BrandVm, Brand>((source) => new Brand
            {
                Id = source.Id,
                Name = source.Name,
                ProductTypes = _instance.Map<ProductTypeVm, ProductType>(source.ProductTypes)?.ToList()
            });
        }
    }
}
