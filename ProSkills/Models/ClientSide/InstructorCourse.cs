using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class InstructorCourse
    {





        [ForeignKey("InstructorId")]
        public int InstractorId { get; set; }          
         public Instructor? Instructor { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }            

        public Course? Course { get; set; }


    }
}
