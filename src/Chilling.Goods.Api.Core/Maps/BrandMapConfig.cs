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
                ProductTypes = source.ProductTypes?.Select(x => _instance.Map<ProductTypeDbo, ProductType>(x.ProductType))?.ToList()
            });

            Mapper.AddMap<Brand, BrandDbo>((source) =>
            {
                var brand = new BrandDbo
                {
                    Id = source.Id,
                    Name = source.Name,
                };

                brand.ProductTypes = source.ProductTypes?.Aggregate(new List<ProductTypeBrandConventionDbo>(), (res, data) =>
                {
                    res.Add(new ProductTypeBrandConventionDbo
                    {
                        Brand = brand,
                        ProductType = _instance.Map<ProductType, ProductTypeDbo>(data)
                    });
                    return res;
                });
                return brand;
            });
            
            Mapper.AddMap<IEnumerable<BrandDbo>, IEnumerable<Brand>>(source 
                => _instance.Map<BrandDbo, Brand>(source).ToList());
        }
    }
}
