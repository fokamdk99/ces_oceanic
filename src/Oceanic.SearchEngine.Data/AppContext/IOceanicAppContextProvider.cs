using DagAir.Addresses.Data.AppContext;

namespace Oceanic.SearchEngine.Data.AppContext
{
    public interface IOceanicAppContextProvider
    {
        OceanicAppContext Provide();
    }
}