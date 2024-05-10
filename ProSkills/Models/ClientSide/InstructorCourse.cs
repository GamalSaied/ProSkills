
using ProSkills.Models.AdminPanel.InstructorManger;
using ProSkills.Models.AdminPanel.InstructorManger;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class InstructorCourse
    {



        public int Id { get; set; }

        [ForeignKey("instructor")]
        public int instructorId { get; set; }          
        public instructor Instructor { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }            

        public Course? Course { get; set; }


    }
}
