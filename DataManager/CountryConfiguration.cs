using HW6_Routing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW6_Routing.DataManager
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {

        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder
                .HasMany(c => c.Cities)
                .WithOne(c => c.Country)
                .HasForeignKey(c => c.Country);

        }
    }

}
