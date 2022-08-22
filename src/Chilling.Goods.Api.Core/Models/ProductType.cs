namespace Chilling.Goods.Api.Core.Models
{
    /// <summary>
    /// Типы продукта
    /// </summary>
    public class ProductType
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

        /// <summary>
        /// Бренды
        /// </summary>
        public List<Brand> Brands { get; set; }
    }
}