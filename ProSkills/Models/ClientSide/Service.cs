using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        [Required]
        public string? InstructorName { get; set; }

        public double Duration { get; set; } // Duration in hours

        public int Rating { get; set; } // Average rating

        public int ReviewCount { get; set; } // Number of reviews
        public string? CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
