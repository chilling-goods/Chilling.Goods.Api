namespace Chilling.Goods.Api.Models;

/// <summary>
/// Модель изображения
/// </summary>
public class ImageVm
{
    /// <summary>
    /// Идентификатор изображения
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// Контент в формате base64
    /// </summary>
    [JsonPropertyName("content")]
    public byte[] Content { get; set; }
}