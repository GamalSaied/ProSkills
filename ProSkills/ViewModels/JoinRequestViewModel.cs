using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ProSkills.ViewModels
{
    public class JoinRequestViewModel
    {
        [Required]
        public int CourseId { get; set; }

        public string? CourseTitle { get; set; }

        [Required]
        public int TraineeId { get; set; }

        [Required]
        [EmailAddress]
        public string? TraineeEmail { get; set; }

        [Required]
        public IFormFile? PaymentProof { get; set; }

        public string? PaymentProofPath { get; set; }
    }
}
