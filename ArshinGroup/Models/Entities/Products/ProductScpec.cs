using ArshinGroup.Domain.Models.Abstractions.BaseEntities;

namespace ArshinGroup.Domain.Models.Entities.Products
{
    public class ProductScpec : BaseFeatures
    {
        public string Lable { get; set; }

        public int? ProductId { get; set; }
        public Product Product { get; set; }
    }
}
