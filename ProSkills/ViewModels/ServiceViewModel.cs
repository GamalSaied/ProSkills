using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.ViewModels
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? InstructorName { get; set; }
        public double Duration { get; set; } // Duration in hours
        public int Rating { get; set; } // Average rating
        public int ReviewCount { get; set; } // Number of reviews
        [NotMapped]
        public IFormFile Image { get; set; } // Add this property for the uploaded file

    }
}
