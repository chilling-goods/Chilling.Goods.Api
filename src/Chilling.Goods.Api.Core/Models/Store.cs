namespace Chilling.Goods.Api.Core.Models;

/// <summary>
/// Модель магазина
/// </summary>
public class Store
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Адрес
    /// </summary>
    public Address Address { get; set; }
}