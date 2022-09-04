using Chilling.Goods.Api.Core.Interfaces;
using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Data.Interfaces;
using Chilling.Goods.Api.Data.Models;
using Chilling.Platform.Mapper.Abstracts;

namespace Chilling.Goods.Api.Core.Services;

public class BrandService: IBrandService
{
    private readonly IBrandProvider _brandProvider;
    private readonly IMapper _mapper;

    public BrandService(IBrandProvider brandProvider, IMapper mapper)
    {
        _brandProvider = brandProvider;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<Brand>> GetAsync(CancellationToken cancellationToken)
    {
       return _mapper.Map<IEnumerable<BrandDbo>, IEnumerable<Brand>>(await _brandProvider.GetAsync(cancellationToken));
    }

    public async Task AddAsync(Brand brand, CancellationToken cancellationToken)
    {
        await _brandProvider.AddAsync(_mapper.Map<Brand, BrandDbo>(brand), cancellationToken);
    }

    public async Task UpdateAsync(Guid id, Brand brand, CancellationToken cancellationToken)
    {
        await _brandProvider.UpdateAsync(id, _mapper.Map<Brand, BrandDbo>(brand), cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        await _brandProvider.DeleteAsync(id, cancellationToken);
    }
}