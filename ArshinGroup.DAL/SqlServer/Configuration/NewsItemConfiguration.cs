using ArshinGroup.Domain.Models.Entities.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArshinGroup.DAL.SqlServer.Configuration
{
    internal class NewsItemConfiguration : IEntityTypeConfiguration<NewsItem>
    {
        public void Configure(EntityTypeBuilder<NewsItem> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}
