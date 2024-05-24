using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class CourseTrainee
    {
        public int Id { get; set; }

        [ForeignKey("Trainee")]
        public int TraineeId { get; set;}
        public Trainee? Trainee { get; set;} 
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course? Course { get; set; }

        public decimal Result { get; set; }
        List<ActivityLog>? ActivitylogList { get; set; }
        List<Certificate>? CertificateList { get; set; }
    }
}
