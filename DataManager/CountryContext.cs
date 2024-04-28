using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using HW6_Routing.Models;
using Microsoft.EntityFrameworkCore;

namespace HW6_Routing.DataManager
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }

        public DbSet<Country> Country { get; set; }

        public DbSet<City> City { get; set; }

    }
}
