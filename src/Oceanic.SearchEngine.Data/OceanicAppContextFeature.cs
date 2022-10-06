using DagAir.Addresses.Data.AppContext;
using Microsoft.Extensions.DependencyInjection;
using Oceanic.SearchEngine.Data.AppContext;

namespace DagAir.Addresses.Data
{
    public static class OceanicAppContextFeature
    {
        public static IServiceCollection AddDagAirAddressesAppDbContext(this IServiceCollection services)
        {
            services.AddSingleton<DagAirAddressesAppContextProvider>();
            services.AddScoped<IOceanicAppContext, OceanicAppContext>(x =>
            {
                var provider = x.GetRequiredService<OceanicAppContextProvider>();
                return provider.Provide();
            });

            return services;
        }
    }
}