using ProSkills.Models.AdminPanel.InstructorManger;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ProSkills.Models.ClientSide
{
    public class Course
    {

        public int Id { get; set; }                   // Create auto
        public string Name { get; set; }              //b7ot feha ely e5trto mel course Category
        public string? CourseImagePath { get; set; } // b7ot feha el category img bta3t elcourse ely e5trto 
        public string Description { get; set; }       // Enter By User
        public DateTime StartAt { get; set; }           // Enter By User
        public DateTime EndAt { get; set; }             // Enter By User
        public int Hours { get; set; }                 // Enter By Redeem Code
        public int NumberOfStudents { get; set; }
        public double TotalFilesSize { get; set; }                   // Maximum Alloable DataSize for this Coruse in Gegabyte
        public int NumberOfAssessment { get; set; }
        public int NumberOfLessons { get; set; }
        public string? Location { get; set; }                        // Location of the course
        public string CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        #region Foriegn Keys
        // MyNew Data
        [ForeignKey("instructor")]
        public int instructorId { get; set; }
        public instructor? Instructor { get; set; }
        #endregion

    }
}

