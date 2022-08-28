using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Data.Models;
using Chilling.Platform.Mapper;
using Chilling.Platform.Mapper.Abstracts;

namespace Chilling.Goods.Api.Core.Maps
{
    public class ProductTypeMapConfig : IMapperConfig
    {
        private readonly IMapper _instance = Mapper.Instance;

        public void AddMaps()
        {
            Mapper.AddMap<ProductTypeDbo, ProductType>((source) => new ProductType
            {
                Id = source.Id,
                Name = source.Name,
                IsDisplay = source.IsDisplay,
                Brands = source.Brands != null
                    ? _instance.Map<BrandDbo, Brand>(source.Brands).ToList()
                    : null,
            });

            Mapper.AddMap<ProductType, ProductTypeDbo>((source) => new ProductTypeDbo
            {
                Id = source.Id,
                Name = source.Name,
                IsDisplay = source.IsDisplay,
                Brands = source.Brands != null
                    ? _instance.Map<Brand, BrandDbo>(source.Brands).ToList()
                    : null
            });
        }
    }
}
