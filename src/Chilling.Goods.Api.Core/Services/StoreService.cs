using Chilling.Goods.Api.Core.Interfaces;
using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Data.Interfaces;
using Chilling.Goods.Api.Data.Models;
using Chilling.Platform.Mapper.Abstracts;

namespace Chilling.Goods.Api.Core.Services;

public class StoreService : IStoreService
{
    private readonly IStoreProvider _storeProvider;
    private readonly IMapper _mapper;

    public StoreService(IStoreProvider storeProvider, IMapper mapper)
    {
        _storeProvider = storeProvider;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<BaseEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        var result = await _storeProvider.GetAllAsync(cancellationToken);
        return _mapper.Map<IEnumerable<StoreDbo>, IEnumerable<BaseEntity>>(result);
    }

    public async Task<Store> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _storeProvider.GetByIdAsync(id, cancellationToken);
        return _mapper.Map<StoreDbo, Store>(result);
    }

    public async Task<Guid> AddAsync(Store store, CancellationToken cancellationToken)
    {
        var request = _mapper.Map<Store, StoreDbo>(store);
        var result = await _storeProvider.AddAsync(request, cancellationToken);
        return result;
    }

    public async Task UpdateAsync(Store store, Guid id, CancellationToken cancellationToken)
    {
        var request = _mapper.Map<Store, StoreDbo>(store);
        await _storeProvider.UpdateAsync(request, id, cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        await _storeProvider.DeleteAsync(id, cancellationToken);
    }
}