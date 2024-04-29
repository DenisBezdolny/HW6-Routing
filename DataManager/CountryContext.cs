using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using HW6_Routing.Models;
using System.Reflection.Emit;


namespace HW6_Routing.DataManager
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Country>().HasData(
                new
                {
                    Id = 1,
                    Name = "China",
                    Population = 1414316220
                },
                new
                {
                    Id = 2,
                    Name = "Italy",
                    Population = 59648521
                   
                }
            );

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Rome", Population = 4000000, CountryId = 2 },
                new City { Id = 2, Name = "Venice", Population = 250000, CountryId = 2 }
            );



        }

            





    }
}
