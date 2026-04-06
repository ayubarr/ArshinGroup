using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Products
{
    public class ProductCategory : BaseTitleInfo
    {
        public string Slug { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
