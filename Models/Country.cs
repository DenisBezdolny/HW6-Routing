namespace HW6_Routing.Models
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public List<City> Cities { get; set; } = new List<City>();
    }
}
