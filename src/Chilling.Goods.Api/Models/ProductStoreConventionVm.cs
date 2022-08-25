namespace Chilling.Goods.Api.Models;

public class ProductStoreConventionVm
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// Продукт
    /// </summary>
    [JsonPropertyName("product")]
    public ProductVm Product { get; set; }

    /// <summary>
    /// Магащин
    /// </summary>
    [JsonPropertyName("store")]
    public StoreVm Store { get; set; }
}