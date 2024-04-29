using HW6_Routing.Models;

namespace HW6_Routing.Services.Abstract_lvl
{
    public interface ICountryService
    {
        public List<int> GetPopulation(string name, string? name2, string? name3);
    }
}
