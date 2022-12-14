using Chilling.Goods.Api.Core.Models;

namespace Chilling.Goods.Api.Core.Interfaces;

public interface IBrandService
{
    /// <summary>
    /// Получение списка брендов
    /// </summary>
    /// <param name="cancellationToken">Токен</param>
    /// <returns>Список брендов</returns>
    Task<IEnumerable<Brand>> GetAllAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Добавление нового бренда
    /// </summary>
    /// <param name="brand">Модель бренда</param>
    /// <param name="cancellationToken">Токен</param>
    /// <returns></returns>
    Task AddAsync(Brand model, CancellationToken cancellationToken);

    /// <summary>
    /// Обновлние модели бренда
    /// </summary>
    /// <param name="id">Идентификатор бренда</param>
    /// <param name="brand">Обновленная модель</param>
    /// <param name="cancellationToken">Токен</param>
    /// <returns></returns>
    Task UpdateAsync(Brand model, Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Удаление бренда
    /// </summary>
    /// <param name="id">Идентификатор бренда</param>
    /// <param name="cancellationToken">Токен</param>
    /// <returns></returns>
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Очистка кеша
    /// </summary>
    /// <returns></returns>
    Task ClearCacheAsync(CancellationToken cancellationToken);
}