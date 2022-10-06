using Microsoft.EntityFrameworkCore;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.DataSeed
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedRoutes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Route>()
                .HasData(
                    new Route()
                    {
                        Id = 1,
                        TravelTime = 8
                    },
                    new Route()
                    {
                        Id = 2,
                        TravelTime = 8
                    }
                );
        }
    }
}