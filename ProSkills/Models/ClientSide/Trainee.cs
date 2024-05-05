using System.ComponentModel.DataAnnotations;

namespace ProSkills.Models.ClientSide
{
    public class Trainee
    {
        public int TraineeId { get; set; }                          // Id From RegistrationList

        [Required(ErrorMessage = "Trainee name is required.")]
        [StringLength(100, ErrorMessage = "Trainee name must be between {2} and {1} characters.", MinimumLength = 2)]
        public string TraineeName { get; set; }
        public string? TraineeImagePath { get; set; }
        public bool IsDefaulImage { get; set; }                      // Indicates if the photo is the default one
        public List<CTask>? AssignedTasks { get; set; }              // Tasks assigned to the student
        public List<CExam>? AssignedExams { get; set; }              // Exams assigned to the student
        public List<CFile>? UploadedFiles { get; set; }              // Files uploaded by the student
        public List<CVideo>? WatchedVideos { get; set; }             // Videos watched by the student

        public string CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        // Forigen Key With
        // Course


    }
}
