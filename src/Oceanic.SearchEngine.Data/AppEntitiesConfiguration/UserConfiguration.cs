using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oceanic.SearchEngine.Data.AppEntities;

namespace Oceanic.SearchEngine.Data.AppEntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ConfigureBase();
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Email)
                .IsRequired();

            builder.Property(e => e.Password)
                .IsRequired();

            builder.Property(e => e.Role)
                .IsRequired();

            builder.Property(e => e.FullName)
                .IsRequired();
        }
    }
}