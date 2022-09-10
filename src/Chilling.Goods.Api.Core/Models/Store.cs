namespace Chilling.Goods.Api.Core.Models;

/// <summary>
/// Модель магазина
/// </summary>
public class Store: BaseEntity
{
    /// <summary>
    /// Телефон
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Адрес
    /// </summary>
    public Address Address { get; set; }
}