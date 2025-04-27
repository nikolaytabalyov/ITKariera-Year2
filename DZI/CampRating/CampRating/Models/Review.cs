using System.ComponentModel.DataAnnotations;

namespace CampRating.Models {
    public class Review {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public int CampingSiteId { get; set; }
        public CampingSite CampingSite { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }

    }
}
