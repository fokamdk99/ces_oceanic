﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.AppEntitiesConfiguration
{
    public class RouteConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.ConfigureBase();
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Country)
                .WithMany(x => x.Addresses)
                .HasForeignKey(e => e.CountryId)
                .IsRequired();
            
            builder.HasOne(e => e.City)
                .WithMany(x => x.Addresses)
                .HasForeignKey(e => e.CityId)
                .IsRequired();
            
            builder.HasOne(e => e.PostalCode)
                .WithMany(x => x.Addresses)
                .HasForeignKey(e => e.PostalCodeId)
                .IsRequired();
        }
    }
}