using HW6_Routing.Models;

namespace HW6_Routing.Services.Abstract_lvl
{
    public interface ICountryService
    {
        public List<Country> GetCountries();
        public Country GetCountry(int countryId);
        public City GetCity(int countryId, int cityId);


    }
}
