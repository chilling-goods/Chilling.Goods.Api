using Newtonsoft.Json;

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
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Отображение типа продукта в списке каталога (не отображать при условии если нет других типов)
        /// </summary>
        [JsonProperty("isDisplay")]
        public bool IsDisplay { get; set; }

        /// <summary>
        /// Бренды
        /// </summary>
        [JsonProperty("brands")]
        public List<BrandVm> Brands { get; set; }
    }
}