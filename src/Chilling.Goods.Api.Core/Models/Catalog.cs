namespace Chilling.Goods.Api.Core.Models
{
    /// <summary>
    /// Каталог
    /// </summary>
    public class Catalog
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
        public List<ProductType> ProductTypes { get; set; }
    }
}