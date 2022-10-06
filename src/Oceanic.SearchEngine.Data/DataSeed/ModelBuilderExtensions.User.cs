using Microsoft.EntityFrameworkCore;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.DataSeed
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                    new User()
                    {
                        Id = 1,
                        Email = "zulu@oceanic.com",
                        FullName = "Mr Zulu",
                        Password = "abc123"
                    },
                    new User()
                    {
                        Id = 2,
                        Email = "stas@oceanic.com",
                        FullName = "Stanislaw",
                        Password = "abc123"
                    }
                );
        }
    }
}