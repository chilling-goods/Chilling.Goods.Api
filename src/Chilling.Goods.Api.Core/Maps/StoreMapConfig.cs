using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Data.Models;
using Chilling.Platform.Mapper;
using Chilling.Platform.Mapper.Abstracts;

namespace Chilling.Goods.Api.Core.Maps;

public class StoreMapConfig: IMapperConfig
{
    private readonly IMapper _instance = Mapper.Instance;
    public void AddMaps()
    {
        Mapper.AddMap<IEnumerable<StoreDbo>, IEnumerable<BaseEntity>>(source 
            => _instance.Map<StoreDbo, BaseEntity>(source).ToList());
        
        Mapper.AddMap<StoreDbo, BaseEntity>(source =>new BaseEntity()
        {
            Id = source.Id,
            Name = source.Name
        });
        
        Mapper.AddMap<StoreDbo, Store>(source => new Store()
        {
            Id = source.Id,
            Address = _instance.Map<AddressDbo, Address>(source.Address),
            Phone = source.Phone,
            Name = source.Name
        });
        
        Mapper.AddMap<Store, StoreDbo>(source => new StoreDbo()
        {
            Id = source.Id,
            Address = _instance.Map<Address, AddressDbo>(source.Address),
            Phone = source.Phone,
            Name = source.Name
        });
    }
}