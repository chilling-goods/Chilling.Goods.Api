namespace Chilling.Goods.Api.Data.Models
{
    /// <summary>
    /// Бренд
    /// </summary>
    public class BrandDbo
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
        public ICollection<ProductTypeBrandConventionDbo> ProductTypes { get; set; }
    }
}