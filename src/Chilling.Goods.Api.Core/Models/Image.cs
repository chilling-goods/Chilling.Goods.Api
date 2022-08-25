namespace Chilling.Goods.Api.Core.Models;

/// <summary>
/// Модель изображения
/// </summary>
public class Image
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