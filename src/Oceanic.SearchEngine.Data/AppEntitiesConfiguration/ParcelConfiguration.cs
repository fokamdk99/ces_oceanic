using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.AppEntitiesConfiguration
{
    public class ParcelConfiguration : IEntityTypeConfiguration<Parcel>
    {
        public void Configure(EntityTypeBuilder<Parcel> builder)
        {
            builder.ConfigureBase();
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id);

            builder.Property(e => e.Weight)
                .IsRequired();

            builder.Property(e => e.Size)
                .IsRequired();

            builder.Property(e => e.Type)
                .IsRequired();

            builder.Property(e => e.Price)
                .IsRequired();

            builder.Property(e => e.FromId)
                .IsRequired();

            builder.Property(e => e.ToId)
                .IsRequired();
        }
    }
}