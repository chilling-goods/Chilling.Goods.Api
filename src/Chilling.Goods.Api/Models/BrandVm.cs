using Newtonsoft.Json;

namespace Chilling.Goods.Api.Models
{
    /// <summary>
    /// Бренд
    /// </summary>
    public class BrandVm : BaseEntityVm
    {
        /// <summary>
        /// Типы продукта
        /// </summary>
        [JsonProperty("productType")]
        public List<ProductTypeVm> ProductTypes { get; set; }
    }
}