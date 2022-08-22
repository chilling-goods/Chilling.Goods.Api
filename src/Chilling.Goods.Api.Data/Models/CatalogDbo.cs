namespace Chilling.Goods.Api.Data.Models
{
    /// <summary>
    /// Каталог
    /// </summary>
    public class CatalogDbo
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Типы продукта
        /// </summary>
        public List<ProductTypeDbo> ProductTypes { get; set; }
    }
}