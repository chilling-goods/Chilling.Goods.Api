using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Models;
using Chilling.Platform.Mapper;

namespace Chilling.Goods.Api.Maps;

/// <summary>
/// Маппинг моделей магазина
/// </summary>
public class StoreMapConfig: IMapperConfig
{
    private readonly IMapper _instance = Mapper.Instance;
    
    public void AddMaps()
    {
        Mapper.AddMap<IEnumerable<BaseEntity>, IEnumerable<BaseEntityVm>>(source 
            => _instance.Map<BaseEntity, BaseEntityVm>(source).ToList() 
        );
        
        Mapper.AddMap<BaseEntity, BaseEntityVm>(source => new BrandVm()
        {
            Id = source.Id,
            Name = source.Name
        });
        
        Mapper.AddMap<Store, StoreVm>(source => new StoreVm()
        {
            Id = source.Id,
            Address = _instance.Map<Address, AddressVm>(source.Address),
            Name = source.Name,
            Phone = source.Phone
        });
        
        Mapper.AddMap<StoreVm, Store>(source => new Store()
        {
            Id = source.Id,
            Address = _instance.Map<AddressVm, Address>(source.Address),
            Name = source.Name,
            Phone = source.Phone
        });
    }
}