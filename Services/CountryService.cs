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

        public List<Country> GetCountries()
        {
            return _countryContext.Country.ToList();
        }

        public Country GetCountry(int countryId)
        {
            Country country = _countryContext.Country
                .FirstOrDefault(c => c.Id == countryId);
            return country;
        }

        public City GetCity(int countryId, int cityId)
        {
            Country country = _countryContext.Country
                .FirstOrDefault(c => c.Id == countryId);
            if (country == null)
            {
                return null;
            }

            City city = country.Cities
                .FirstOrDefault(c => c.Id == cityId);
            return city;
        }
    }
}
