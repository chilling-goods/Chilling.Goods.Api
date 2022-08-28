namespace Chilling.Goods.Api.Core.Models;

/// <summary>
/// Модель адреса
/// </summary>
public class Address
{
    /// <summary>
    /// Полный адрес
    /// </summary>
    public string FullAddress { get; set; }
    
    /// <summary>
    /// Регион
    /// </summary>
    public string Region { get; set; }
    
    /// <summary>
    /// Район (возможно не нужен)
    /// </summary>
    public string District { get; set; }
    
    /// <summary>
    /// Город
    /// </summary>
    public string City { get; set; }
    
    /// <summary>
    /// Населенный пункт
    /// </summary>
    public string Locality { get; set; }
    
    /// <summary>
    /// Улица
    /// </summary>
    public string Street { get; set; }
    
    /// <summary>
    /// Дом
    /// </summary>
    public string House { get; set; }
    
    /// <summary>
    /// Корпус
    /// </summary>
    public string Corpuse { get; set; }
    
    /// <summary>
    /// Строение
    /// </summary>
    public string Building { get; set; }
    
    /// <summary>
    /// Квартира
    /// </summary>
    public string Flat { get; set; }
    
    /// <summary>
    /// Индекс
    /// </summary>
    public string Index { get; set; }
}