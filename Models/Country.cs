using Microsoft.Extensions.Hosting;
using System.Numerics;

namespace HW6_Routing.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }

        public ICollection<City> Cities { get; set; } = new List<City>();

    }
}
