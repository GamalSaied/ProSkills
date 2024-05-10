using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string? TraineeImagePath { get; set; }
        public string CourseCategory { get; set; }
        public string Description { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public string CreatedAt { get; set; }
        public int Hours { get; set; }
        public int NumberOfStudents { get; set; }
        public double TotalFilesSize { get; set; }                   // Maximum Alloable DataSize for this Coruse in Gegabyte
        public int NumberOfAssessment { get; set; }
        public int NumberOfLessons { get; set; }
        public string? Location { get; set; }                        // Location of the course

        public int maxDegree {  get; set; }
        public int minDegree { get; set; }

        public bool IsDeleted { get; set; }

        #region Foriegn Keys
        //public ICollection<InstructorCourse> instructorCourse { get; set; }
        //public ICollection<Enrollment>?  enrollments { get; set; }
        //public ICollection<Module> modules { get; set; }    

        // MyNew Data
        [ForeignKey("instructor")]
        public int instructorId { get; set; }
        public instructor? Instructor { get; set; }
        #endregion

    }
}

