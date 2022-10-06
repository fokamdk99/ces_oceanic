using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.AppEntitiesConfiguration
{
    public class RouteConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.ConfigureBase();
            builder.HasKey(e => e.Id);

            builder.Property(e => e.TravelTime)
                .IsRequired();
        }
    }
}