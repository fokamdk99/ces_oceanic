using Microsoft.EntityFrameworkCore;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.DataSeed
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedParcels(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parcel>()
                .HasData(
                    new Parcel()
                    {
                        Id = 1,
                        Weight = 2
                    },
                    new Parcel()
                    {
                        Id = 2,
                        Weight = 4
                    }
                );
        }
    }
}