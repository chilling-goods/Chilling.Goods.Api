namespace Chilling.Goods.Api.Data.Models;

/// <summary>
/// Модель магазина
/// </summary>
public class StoreDbo
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
    public AddressDbo Address { get; set; }
}