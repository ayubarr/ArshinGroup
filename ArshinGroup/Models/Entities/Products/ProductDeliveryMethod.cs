using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Products
{
    public class ProductDeliveryMethod : BaseEntity
    {
        public string Method { get; set; }

        public int? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
