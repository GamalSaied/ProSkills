using ProSkills.Models.AdminPanel.InstructorManger;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class Steps
    {

        public int Id { get; set; }
        public string? Name { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course? Course { get; set; }

    }
}
