namespace Chilling.Goods.Api.Models;

/// <summary>
/// Базовая вью-модель
/// </summary>
public class BaseEntityVm
{
    /// <summary>
    /// ID
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}