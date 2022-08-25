namespace Chilling.Goods.Api.Core.Models;

public class ProductStoreConvention
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Продукт
    /// </summary>
    public Product Product { get; set; }

    /// <summary>
    /// Магащин
    /// </summary>
    public Store Store { get; set; }
}