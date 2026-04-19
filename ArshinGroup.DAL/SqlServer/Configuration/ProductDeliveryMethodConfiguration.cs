using ArshinGroup.Domain.Models.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArshinGroup.DAL.SqlServer.Configuration
{
    internal class ProductDeliveryMethodConfiguration : IEntityTypeConfiguration<ProductDeliveryMethod>
    {
        public void Configure(EntityTypeBuilder<ProductDeliveryMethod> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}
