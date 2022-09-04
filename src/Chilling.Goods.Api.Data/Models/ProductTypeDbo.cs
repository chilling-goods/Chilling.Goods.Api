namespace Chilling.Goods.Api.Data.Models
{
    /// <summary>
    /// Типы продукта
    /// </summary>
    public class ProductTypeDbo
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отображение типа продукта в списке каталога (не отображать при условии если нет других типов)
        /// </summary>
        public bool IsDisplay { get; set; }

        public CatalogDbo Catalog { get; set; }

        public Guid CatalogId { get; set; }

        /// <summary>
        /// Бренды
        /// </summary>
        public ICollection<ProductTypeBrandConventionDbo> Brands { get; set; }
    }
}