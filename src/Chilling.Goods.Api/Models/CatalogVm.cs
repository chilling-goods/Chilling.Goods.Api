namespace Chilling.Goods.Api.Models
{
    /// <summary>
    /// Каталог
    /// </summary>
    public class CatalogVm
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Типы продукта
        /// </summary>
        [JsonPropertyName("productTypes")]
        public List<ProductTypeVm> ProductTypes { get; set; }
    }
}