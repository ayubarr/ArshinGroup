using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Products
{
    public class ProductImage : BaseEntity
    {
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        public string Url { get; set; }
    }
}
