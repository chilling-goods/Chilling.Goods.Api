namespace Chilling.Goods.Api.Models;

/// <summary>
/// Модель тэга
/// </summary>
public class TagVm
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// Название тэга
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}