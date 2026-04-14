using ArshinGroup.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace ArshinGroup.DAL.SqlServer.Helpers
{
    internal static class PropertyHelper<T>
          where T : class
    {
        internal static void SetProperties(EntityTypeBuilder<T> builder, bool isMaxLength = false,
            params Expression<Func<T, string>>[] properties)
        {
            foreach (var property in properties)
            {
                builder.Property(property)
                    .HasMaxLength(isMaxLength ? DefaultConstraints.DefaultMaxLength : DefaultConstraints.DefaultLength)
                    .HasColumnType("varchar");
            }
        }
    }
}
