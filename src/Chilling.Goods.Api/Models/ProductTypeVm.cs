namespace Chilling.Goods.Api.Models
{
    /// <summary>
    /// Типы продукта
    /// </summary>
    public class ProductTypeVm
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Отображение типа продукта в списке каталога (не отображать при условии если нет других типов)
        /// </summary>
        [JsonPropertyName("isDisplay")]
        public bool IsDisplay { get; set; }

        /// <summary>
        /// Бренды
        /// </summary>
        [JsonPropertyName("brands")]
        public List<BrandVm> Brands { get; set; }
    }
}