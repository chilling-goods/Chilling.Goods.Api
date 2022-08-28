namespace Chilling.Goods.Api.Data.Models;

/// <summary>
/// Модель изображения
/// </summary>
public class ImageDbo
{
    /// <summary>
    /// Идентификатор изображения
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Контент в формате base64
    /// </summary>
    public byte[] Content { get; set; }
}