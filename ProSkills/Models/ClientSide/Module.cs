using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        #region



        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public Course? course { get; set; }

        [ForeignKey("InstructorId")]
        public int InstructorId { get; set; }
        public Instructor instructor { get; set; }

        ICollection<Lesson> lessons { get; set; }
        ICollection<Assessment> assessment { get; set; }

        #endregion








    }
}
