using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Models;
using Chilling.Platform.Mapper;

namespace Chilling.Goods.Api.Maps;

public class AddressMapConfig: IMapperConfig
{
    public void AddMaps()
    {
        Mapper.AddMap<AddressVm, Address>(source => new Address()
        {
            FullAddress = source.FullAddress,
            Region = source.Region,
            Street = source.Street,
            Corpuse = source.Corpuse,
            District = source.District,
            Building = source.Building,
            Index = source.Index,
            City = source.City,
            Locality = source.Locality,
            House = source.House
        });
        
        Mapper.AddMap<Address, AddressVm>(source => new AddressVm()
        {
            FullAddress = source.FullAddress,
            Region = source.Region,
            Street = source.Street,
            Corpuse = source.Corpuse,
            District = source.District,
            Building = source.Building,
            Index = source.Index,
            City = source.City,
            Locality = source.Locality,
            House = source.House
        });
    }
}