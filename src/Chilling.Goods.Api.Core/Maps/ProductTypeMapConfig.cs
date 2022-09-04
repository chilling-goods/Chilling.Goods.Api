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
                Brands = source.Brands?.Select(x => _instance.Map<BrandDbo, Brand>(x.Brand))?.ToList()
            });

            Mapper.AddMap<ProductType, ProductTypeDbo>((source) =>
            {
                var productType = new ProductTypeDbo
                {
                    Id = source.Id,
                    Name = source.Name,
                    IsDisplay = source.IsDisplay
                };

                productType.Brands = source.Brands?.Aggregate(new List<ProductTypeBrandConventionDbo>(), (res, data) =>
                {
                    res.Add(new ProductTypeBrandConventionDbo
                    {
                        ProductType = productType,
                        Brand = _instance.Map<Brand, BrandDbo>(data)
                    });
                    return res;
                });
                return productType;
            });
        }
    }
}
