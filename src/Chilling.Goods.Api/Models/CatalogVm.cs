using Newtonsoft.Json;

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
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Типы продукта
        /// </summary>
        [JsonProperty("productTypes")]
        public List<ProductTypeVm> ProductTypes { get; set; }
    }
}