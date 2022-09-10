using Chilling.Goods.Api.Data.Models;

namespace Chilling.Goods.Api.Data.Interfaces;

public interface IStoreProvider
{
    /// <summary>
    /// Получение списка всех магазинов
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<StoreDbo>> GetAllAsync(CancellationToken cancellationToken);
    
    /// <summary>
    /// Получение магазина по Id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<StoreDbo> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    
    /// <summary>
    /// Добавление магазина
    /// </summary>
    /// <param name="store"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Guid> AddAsync(StoreDbo store, CancellationToken cancellationToken);

    /// <summary>
    /// Обновление информации о магазине
    /// </summary>
    /// <param name="store"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(StoreDbo store, Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Удаление магазина
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}