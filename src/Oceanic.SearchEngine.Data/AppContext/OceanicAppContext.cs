using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Oceanic.SearchEngine.Data.AppContext;
using Oceanic.SearchEngine.Data.AppEntities;
using Oceanic.SearchEngine.Data.DataSeed;

namespace DagAir.Addresses.Data.AppContext
{
    public class OceanicAppContext : DbContext, IOceanicAppContext
    {
        private const string Schema = "db-oa-dk3";
        
        public OceanicAppContext() {}
        
        public OceanicAppContext(DbContextOptions<OceanicAppContext> options) : base(options) {}

        public DbSet<City> Cities { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSnakeCaseNamingConvention();
            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.HasDefaultSchema(Schema);
            
            SeedData(modelBuilder);
            
            base.OnModelCreating(modelBuilder);
        }
        
        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedCities();
            modelBuilder.SeedParcels();
            modelBuilder.SeedPricings();
            modelBuilder.SeedRoutes();
            modelBuilder.SeedUsers();
        }
    }
}