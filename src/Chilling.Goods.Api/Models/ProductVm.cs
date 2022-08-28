namespace Chilling.Goods.Api.Models;

/// <summary>
/// Модель продукта
/// </summary>
public class ProductVm
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    
    /// <summary>
    /// Название
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// Размер
    /// </summary>
    [JsonPropertyName("size")]
    public string Size { get; set; }

    /// <summary>
    /// Стоимость
    /// </summary>
    [JsonPropertyName("price")]
    public decimal? Price { get; set; }

    /// <summary>
    /// Описание с содержанием html tags (<b>message</b>)
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Бренд
    /// </summary>
    [JsonPropertyName("brand")]
    public BrandVm Brand { get; set; }

    /// <summary>
    /// Тип продукта
    /// </summary>
    [JsonPropertyName("productType")]
    public ProductTypeVm ProductType { get; set; }

    /// <summary>
    /// Изображения
    /// </summary>
    [JsonPropertyName("images")]
    public IEnumerable<ImageVm> Images { get; set; }

    /// <summary>
    /// Тэги
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<TagVm> Tags { get; set; }

    /// <summary>
    /// Рейтинг
    /// </summary>
    [JsonPropertyName("rating")]
    public RatingVm Rating { get; set; }
}