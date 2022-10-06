using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Oceanic.SearchEngine.Data.AppContext;

namespace DagAir.Addresses.Data.AppContext
{
    public class OceanicAppContextProvider : IOceanicAppContextProvider
    {
        private const string ConnectionStringName = "DagAir.Addresses";
        private readonly string _connectionString;
        private readonly ILoggerFactory _loggerFactory;

        public OceanicAppContextProvider(IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            var connectionString = configuration.GetConnectionString(ConnectionStringName);
            _connectionString = connectionString + configuration[$"ConnectionKeys:{ConnectionStringName}"] + ";";
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException(
                    $"Connection string for '{ConnectionStringName}' is not defined. Please provide a value.");
            }
        }
        public OceanicAppContext Provide()
        {
            var contextOptions = new DbContextOptionsBuilder<OceanicAppContext>()
                .UseLoggerFactory(_loggerFactory)
                .UseMySQL(_connectionString)
                .Options;

            return new DagAirAddressesAppContext(contextOptions);
        }
    }
}