using Microsoft.EntityFrameworkCore;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.DataSeed
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedPricings(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pricing>()
                .HasData(
                    new Pricing()
                    {
                        Id = 1,
                        Price = 10
                    },
                    new Pricing()
                    {
                        Id = 2,
                        Price = 12
                    }
                );
        }
    }
}