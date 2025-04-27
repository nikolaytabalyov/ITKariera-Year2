using System.ComponentModel.DataAnnotations;

namespace CampRating.Models {
    public class CampingSite {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }
        [Url]
        public string PhotoUrl { get; set; } 
    }
}
