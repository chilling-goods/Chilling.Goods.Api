namespace Chilling.Goods.Api.Models;

/// <summary>
/// Модель магазина
/// </summary>
public class StoreVm
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Адрес
    /// </summary>
    [JsonPropertyName("address")]
    public AddressVm Address { get; set; }
}