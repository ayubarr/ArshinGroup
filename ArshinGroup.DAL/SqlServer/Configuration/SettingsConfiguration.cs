using ArshinGroup.DAL.SqlServer.Helpers;
using ArshinGroup.Domain.Models.Entities.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArshinGroup.DAL.SqlServer.Configuration
{
    internal class SettingsConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.HasKey(u => u.Id);

            PropertyHelper<Setting>.SetProperties(builder, false,
                s => s.Key
            );

        }
    }
}
