using HW6_Routing.Models;
using HW6_Routing.Services;
using HW6_Routing.Services.Abstract_lvl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW6_Routing.Controllers
{
    public class CountryController : Controller
    {

        ICountryService countryService;

        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }



        // GET: CountryController1
        public ActionResult Index()
        {

            return View();
        }



        [Route("country/{name}/{name2?}/{name3?}")]
        public ActionResult GetPopulation(string name, string? name2, string? name3)
        {

            List<int> population = countryService.GetPopulation(name, name2, name3);
            return Ok(population);



        }




    }
}
