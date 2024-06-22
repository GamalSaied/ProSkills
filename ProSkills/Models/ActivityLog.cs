using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime ActivityDate { get; set; }
        public string ActivityType { get; set; } // e.g., "LessonCompleted"
        public string Description { get; set; }
        public int LessonId { get; set; }

        [ForeignKey("LessonId")]
        public Lesson Lesson { get; set; }
        public bool IsDeleted { get; set; }
    }


}
