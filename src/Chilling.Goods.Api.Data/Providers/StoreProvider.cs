using Chilling.Goods.Api.Data.Interfaces;
using Chilling.Goods.Api.Data.Models;

namespace Chilling.Goods.Api.Data.Providers;

public class StoreProvider : IStoreProvider
{
    private readonly GoodsDbContext _dbContext;

    public StoreProvider(GoodsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<StoreDbo>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await Task.FromResult(new List<StoreDbo>()
        {
            new StoreDbo()
            {
                Id = Guid.NewGuid(),
                Address = new AddressDbo()
                {
                    City = "Moscow"
                }
            }
        });
    }

    public async Task<StoreDbo> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await Task.FromResult<StoreDbo>(new StoreDbo()
        {
            Id = Guid.NewGuid(),
            Address = new AddressDbo()
            {
                City = "Moscow"
            }
        });
    }

    public async Task<Guid> AddAsync(StoreDbo store, CancellationToken cancellationToken)
    {
        return await Task.FromResult(Guid.NewGuid());
    }

    public Task UpdateAsync(StoreDbo store, Guid id, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}