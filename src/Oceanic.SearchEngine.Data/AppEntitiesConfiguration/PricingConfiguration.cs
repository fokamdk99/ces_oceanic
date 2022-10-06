using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.AppEntitiesConfiguration
{
    public class PricingConfiguration : IEntityTypeConfiguration<Pricing>
    {
        public void Configure(EntityTypeBuilder<Pricing> builder)
        {
            builder.ConfigureBase();
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Price)
                .IsRequired();
        }
    }
}