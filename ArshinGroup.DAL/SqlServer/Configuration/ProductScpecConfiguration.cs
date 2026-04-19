using ArshinGroup.Domain.Models.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArshinGroup.DAL.SqlServer.Configuration
{
    internal class ProductScpecConfiguration : IEntityTypeConfiguration<ProductScpec>
    {
        public void Configure(EntityTypeBuilder<ProductScpec> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}
