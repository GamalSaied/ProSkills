using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class Enrollment
    {

        public int Id { get; set; }

        public DateTime EnrollDate { get; set; }
        public string FinalGrade { get; set; }


        #region

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public Course? Course { get; set; }

        [ForeignKey("TraineeId")]
        public int TraineeId {  get; set; }
        public Trainee? Trainee { get; set; }
        #endregion
    
    
    }
}
