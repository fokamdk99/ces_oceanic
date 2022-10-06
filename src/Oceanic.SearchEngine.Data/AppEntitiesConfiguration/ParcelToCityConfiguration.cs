using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.AppEntitiesConfiguration
{
    public class ParcelToCityConfiguration : IEntityTypeConfiguration<ParcelToCity>
    {
        public void Configure(EntityTypeBuilder<ParcelToCity> builder)
        {
            builder.ConfigureBase();
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id);

            builder.Property(e => e.City)
                .IsRequired();

            builder.Property(e => e.Parcel)
                .IsRequired();
        }
    }
}
