using Newtonsoft.Json;

namespace Chilling.Goods.Api.Models
{
    /// <summary>
    /// Бренд
    /// </summary>
    public class BrandVm
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
        [JsonProperty("productType")]
        public List<ProductTypeVm> ProductTypes { get; set; }
    }
}