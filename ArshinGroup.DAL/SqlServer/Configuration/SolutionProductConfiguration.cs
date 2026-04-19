using ArshinGroup.Domain.Models.Entities.Solutions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArshinGroup.DAL.SqlServer.Configuration
{
    internal class SolutionProductConfiguration : IEntityTypeConfiguration<SolutionProduct>
    {
        public void Configure(EntityTypeBuilder<SolutionProduct> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}
