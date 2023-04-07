namespace Chilling.Goods.Api.Core.Models;

/// <summary>
/// Базовая модель
/// </summary>
public class BaseEntity
{
    /// <summary>
    /// ID
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; }
}