using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Data.Models;
using Chilling.Platform.Mapper;
using Chilling.Platform.Mapper.Abstracts;

namespace Chilling.Goods.Api.Core.Maps;

public class AddressMapConfig: IMapperConfig
{
    public void AddMaps()
    {
        Mapper.AddMap<AddressDbo, Address>(source => new Address()
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
        
        Mapper.AddMap<Address, AddressDbo>(source => new AddressDbo()
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