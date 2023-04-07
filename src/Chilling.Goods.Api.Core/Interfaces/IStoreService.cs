using Chilling.Goods.Api.Core.Models;

namespace Chilling.Goods.Api.Core.Interfaces;

public interface IStoreService
{
    /// <summary>
    /// Получение списка всех магазинов
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<BaseEntity>> GetAllAsync(CancellationToken cancellationToken);
    
    /// <summary>
    /// Получение магазина по Id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Store> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    
    /// <summary>
    /// Добавление магазина
    /// </summary>
    /// <param name="store"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Guid> AddAsync(Store store, CancellationToken cancellationToken);

    /// <summary>
    /// Обновление информации о магазине
    /// </summary>
    /// <param name="store"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(Store store, Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Удаление магазина
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}