using ArshinGroup.DAL.SqlServer.Helpers;
using ArshinGroup.Domain.Models.Abstractions.BaseEntities;
using ArshinGroup.Domain.Models.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArshinGroup.DAL.SqlServer.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
      
        }
    }
}
