namespace Chilling.Goods.Api.Models;

/// <summary>
/// Модель адреса
/// </summary>
public class AddressVm
{
    /// <summary>
    /// Полный адрес
    /// </summary>
    [JsonPropertyName("fullAddress")]
    public string FullAddress { get; set; }
    
    /// <summary>
    /// Регион
    /// </summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
    
    /// <summary>
    /// Район (возможно не нужен)
    /// </summary>
    [JsonPropertyName("district")]
    public string District { get; set; }
    
    /// <summary>
    /// Город
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }
    
    /// <summary>
    /// Населенный пункт
    /// </summary>
    [JsonPropertyName("locality")]
    public string Locality { get; set; }
    
    /// <summary>
    /// Улица
    /// </summary>
    [JsonPropertyName("street")]
    public string Street { get; set; }
    
    /// <summary>
    /// Дом
    /// </summary>
    [JsonPropertyName("house")]
    public string House { get; set; }
    
    /// <summary>
    /// Корпус
    /// </summary>
    [JsonPropertyName("corpuse")]
    public string Corpuse { get; set; }
    
    /// <summary>
    /// Строение
    /// </summary>
    [JsonPropertyName("building")]
    public string Building { get; set; }
    
    /// <summary>
    /// Квартира
    /// </summary>
    [JsonPropertyName("flat")]
    public string Flat { get; set; }
    
    /// <summary>
    /// Индекс
    /// </summary>
    [JsonPropertyName("index")]
    public string Index { get; set; }
}