using Chilling.Goods.Api.Data.Models;

namespace Chilling.Goods.Api.Data.Interfaces;

public interface IBrandProvider
{
    /// <summary>
    /// Получение списка брендов
    /// </summary>
    /// <param name="cancellationToken">Токен</param>
    /// <returns>Список брендов</returns>
    Task<IEnumerable<BrandDbo>> GetAsync(CancellationToken cancellationToken);
    
    /// <summary>
    /// Добавление нового бренда
    /// </summary>
    /// <param name="brand">Модель бренда</param>
    /// <param name="cancellationToken">Токен</param>
    /// <returns></returns>
    Task AddAsync(BrandDbo brand, CancellationToken cancellationToken);

    /// <summary>
    /// Обновлние модели бренда
    /// </summary>
    /// <param name="id">Идентификатор бренда</param>
    /// <param name="brand">Обновленная модель</param>
    /// <param name="cancellationToken">Токен</param>
    /// <returns></returns>
    Task UpdateAsync(Guid id, BrandDbo brand, CancellationToken cancellationToken);

    /// <summary>
    /// Удаление бренда
    /// </summary>
    /// <param name="id">Идентификатор бренда</param>
    /// <param name="cancellationToken">Токен</param>
    /// <returns></returns>
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}