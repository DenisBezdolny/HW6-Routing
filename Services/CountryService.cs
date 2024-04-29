using HW6_Routing.DataManager;
using HW6_Routing.Models;
using HW6_Routing.Services.Abstract_lvl;
using Microsoft.EntityFrameworkCore;

namespace HW6_Routing.Services
{
    public class CountryService : ICountryService
    {
        private readonly CountryContext _countryContext;

        public CountryService() { } 
        public CountryService(CountryContext countryContext) {  _countryContext = countryContext; }

        
        public List <int> GetPopulation(string name, string? name2, string? name3)
        {
            Country country = _countryContext.Countries.FirstOrDefault(c => c.Name == name);
            City city = _countryContext.Cities.FirstOrDefault(c => c.Name == name2);
            City city2 = _countryContext.Cities.FirstOrDefault(c => c.Name == name3);

            if (name2 == null ) {
                return new List<int> { country.Population };
            }
            if (name3 == null)
            {
                return new List<int> { city.Population };
            }
            else
            {
                return new List<int> { city.Population, city2.Population };
            }

        }


    }
}
