using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travel_Locations.Models
{
    public class Locations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public required string LocationName { get; set; }
        public required string Country { get; set; }
        public required string City { get; set; }
        public required string Description { get; set; }
        public required string Image { get; set; }
        public required string Location { get; set; }
    }
}
