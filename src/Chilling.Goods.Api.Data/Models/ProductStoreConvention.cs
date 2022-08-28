namespace Chilling.Goods.Api.Data.Models;

public class ProductStoreConventionDbo
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Продукт
    /// </summary>
    public ProductDbo Product { get; set; }

    /// <summary>
    /// Магащин
    /// </summary>
    public StoreDbo Store { get; set; }
}