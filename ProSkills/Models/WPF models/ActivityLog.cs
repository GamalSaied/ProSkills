using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class ActivityLog
    {

        public int Id { get; set; }
        public string? Name { get; set; }

        [ForeignKey("CourseTrainee")]
        public int CourseTraineeId { get; set; }
        public CourseTrainee? CourseTrainee { get; set; }

    }
}
