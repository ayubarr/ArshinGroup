using ArshinGroup.Domain.Models.Entities.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArshinGroup.DAL.SqlServer.Configuration
{
    internal class NavigationItemConfiguration : IEntityTypeConfiguration<NavigationItem>
    {
        public void Configure(EntityTypeBuilder<NavigationItem> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasOne(n => n.Parent)
                .WithMany(n => n.Children)
                .HasForeignKey(n => n.ParrentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(n => n.NavigationMenu)
                .WithMany(m => m.NavigationItems)
                .HasForeignKey(n => n.MenuId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
