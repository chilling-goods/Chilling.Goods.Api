namespace Chilling.Goods.Api.Data.Models
{
    public class ProductTypeBrandConventionDbo
    {
        public int Id { get; set; }

        public BrandDbo Brand { get; set; }

        public Guid BrandId { get; set; }

        public ProductTypeDbo ProductType { get; set; }

        public Guid ProductTypeId { get; set; }
    }
}
