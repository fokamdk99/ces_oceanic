using Microsoft.EntityFrameworkCore;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.DataSeed
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedParcelToCity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParcelToCity>()
                .HasData(
                    new ParcelToCity()
                    {
                        Id = 1,
                        Parcel = new Parcel
                        {
                            Id = 1
                        },
                        City = new City
                        {
                            Id = 1
                        }
                    }
                );
        }
    }
}