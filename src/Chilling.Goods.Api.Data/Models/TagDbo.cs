namespace Chilling.Goods.Api.Data.Models;

/// <summary>
/// Модель тэга
/// </summary>
public class TagDbo
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Название тэга
    /// </summary>
    public string Name { get; set; }
}