namespace Chilling.Goods.Api.Core.Models;

/// <summary>
/// Модель продукта
/// </summary>
public class Product
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
    public Brand Brand { get; set; }

    /// <summary>
    /// Тип продукта
    /// </summary>
    public ProductType ProductType { get; set; }

    /// <summary>
    /// Изображения
    /// </summary>
    public IEnumerable<Image> Images { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IEnumerable<ProductStoreConvention> ProductStoreConventions { get; set; }

    /// <summary>
    /// Тэги
    /// </summary>
    public IEnumerable<Tag> Tags { get; set; }

    /// <summary>
    /// Рейтинг
    /// </summary>
    public Rating Rating { get; set; }
}