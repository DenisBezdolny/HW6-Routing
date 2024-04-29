using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW6_Routing.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }

    }
}
