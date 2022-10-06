using DagAir.Addresses.Data.AppContext;
using Microsoft.Extensions.DependencyInjection;
using Oceanic.SearchEngine.Data.AppContext;

namespace Oceanic.SearchEngine.Data
{
    public static class OceanicAppContextFeature
    {
        public static IServiceCollection AddDagAirAddressesAppDbContext(this IServiceCollection services)
        {
            services.AddSingleton<OceanicAppContextProvider>();
            services.AddScoped<IOceanicAppContext, OceanicAppContext>(x =>
            {
                var provider = x.GetRequiredService<OceanicAppContextProvider>();
                return provider.Provide();
            });

            return services;
        }
    }
}