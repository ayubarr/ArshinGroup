using ArshinGroup.Domain.Models.Entities.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArshinGroup.DAL.SqlServer.Configuration
{
    internal class ServiceFeatureConfiguration : IEntityTypeConfiguration<ServiceFeature>
    {
        public void Configure(EntityTypeBuilder<ServiceFeature> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}
