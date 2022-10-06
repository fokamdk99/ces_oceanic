using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.AppContext
{
    public interface IOceanicAppContext
    {
        public DatabaseFacade Database { get; }
        public IModel Model { get; }
        
        public DbSet<City> Cities { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<User> Users { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}