namespace Chilling.Goods.Api.Data.Models;

/// <summary>
/// Модель продукта
/// </summary>
public class ProductDbo
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Размер
    /// </summary>
    public string Size { get; set; }

    /// <summary>
    /// Стоимость
    /// </summary>
    public decimal? Price { get; set; }

    /// <summary>
    /// Описание с содержанием html tags (<b>message</b>)
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Бренд
    /// </summary>
    public BrandDbo Brand { get; set; }

    /// <summary>
    /// Тип продукта
    /// </summary>
    public ProductTypeDbo ProductType { get; set; }

    /// <summary>
    /// Изображения
    /// </summary>
    public IEnumerable<ImageDbo> Images { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IEnumerable<ProductStoreConventionDbo> ProductStoreConventions { get; set; }

    /// <summary>
    /// Тэги
    /// </summary>
    public IEnumerable<TagDbo> Tags { get; set; }

    /// <summary>
    /// Рейтинг
    /// </summary>
    public RatingDbo Rating { get; set; }
}