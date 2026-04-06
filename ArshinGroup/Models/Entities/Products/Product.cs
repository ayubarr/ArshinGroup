using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Products
{
    public class Product : BaseOrderInfo
    {
        public string ChinaPrice { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int? CategoryId { get; set; }
        public ProductCategory Category { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductDeliveryMethod> ProductDeliveryMethods { get; set; }
        public ICollection<ProductScpec> ProductScpecs { get; set; }
    }
}
