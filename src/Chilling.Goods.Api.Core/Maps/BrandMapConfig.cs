using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Data.Models;
using Chilling.Platform.Mapper;
using Chilling.Platform.Mapper.Abstracts;

namespace Chilling.Goods.Api.Core.Maps
{
    public class BrandMapConfig : IMapperConfig
    {
        private readonly IMapper _instance = Mapper.Instance;

        public void AddMaps()
        {
            Mapper.AddMap<BrandDbo, Brand>((source) => new Brand
            {
                Id = source.Id,
                Name = source.Name,
                ProductTypes = source.ProductTypes != null
                    ? _instance.Map<ProductTypeDbo, ProductType>(source.ProductTypes).ToList()
                    : null
            });

            Mapper.AddMap<Brand, BrandDbo>((source) => new BrandDbo
            {
                Id = source.Id,
                Name = source.Name,
                ProductTypes = source.ProductTypes != null
                    ? _instance.Map<ProductType, ProductTypeDbo>(source.ProductTypes).ToList()
                    : null
            });
            
            Mapper.AddMap<IEnumerable<BrandDbo>, IEnumerable<Brand>>(source 
                => _instance.Map<BrandDbo, Brand>(source).ToList());
        }
    }
}
