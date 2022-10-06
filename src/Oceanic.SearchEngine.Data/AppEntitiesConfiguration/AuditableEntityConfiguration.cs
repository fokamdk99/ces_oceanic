using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.AppEntitiesConfiguration
{
    public static class AuditableEntityConfiguration
    {
        public static void ConfigureBase<T>(this EntityTypeBuilder<T> builder) where T : AuditableEntity
        {
            builder.Property(e => e.Created)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Modified);
        }
    }
}