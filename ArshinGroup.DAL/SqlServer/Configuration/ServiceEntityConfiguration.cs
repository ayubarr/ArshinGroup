using ArshinGroup.Domain.Models.Entities.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArshinGroup.DAL.SqlServer.Configuration
{
    internal class ServiceEntityConfiguration : IEntityTypeConfiguration<ServiceEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceEntity> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasOne(s => s.ServiceCategory)
                .WithMany(c => c.Services)
                .HasForeignKey(s => s.ServiceCategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(s => s.ServiceFeatures)
                .WithOne(f => f.ServiceEntity)
                .HasForeignKey(f => f.ServiceId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
