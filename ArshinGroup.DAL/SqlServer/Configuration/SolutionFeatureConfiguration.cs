using ArshinGroup.Domain.Models.Entities.Solutions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArshinGroup.DAL.SqlServer.Configuration
{
    internal class SolutionFeatureConfiguration : IEntityTypeConfiguration<SolutionFeature>
    {
        public void Configure(EntityTypeBuilder<SolutionFeature> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}
