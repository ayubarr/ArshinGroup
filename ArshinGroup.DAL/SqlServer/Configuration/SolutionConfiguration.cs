using ArshinGroup.Domain.Models.Entities.Solutions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArshinGroup.DAL.SqlServer.Configuration
{
    internal class SolutionConfiguration : IEntityTypeConfiguration<Solution>
    {
        public void Configure(EntityTypeBuilder<Solution> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasMany(s => s.Features)
                   .WithOne(f => f.Solution)
                   .HasForeignKey(f => f.SolutionId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(s => s.SolutionProducts)
                    .WithOne(sp => sp.Solution)
                    .HasForeignKey(sp => sp.SolutionId)
                    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
