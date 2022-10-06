using DagAir.Addresses.Data.AppContext;
using DagAir.Addresses.Data.Migrations.Context;

namespace OceanicSearchEngine.Data.Migrations.Context
{
    public class AppContextFactory : ContextFactory<OceanicAppContext>
    {
        protected override string ConnectionString => "Oceanic";
    }
}