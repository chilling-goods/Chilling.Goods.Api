namespace Chilling.Goods.Api.Core.Models;

/// <summary>
/// Модель тэга
/// </summary>
public class Tag
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