namespace Chilling.Goods.Api.Models;

/// <summary>
/// Модель магазина
/// </summary>
public class StoreVm: BaseEntityVm
{
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