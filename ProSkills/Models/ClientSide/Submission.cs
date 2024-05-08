using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class Submission
    {


        public int Id { get; set; }

        public int Score { get; set; }

        public DateTime SubmittedDate { get; set; }

        #region ForiegnKey

        [ForeignKey("TraineeId")]
        public int TraineeId { get; set; }
        public Trainee trainee { get; set; }

        [ForeignKey("AssessmentId")]
        public int AssessmentId { get; set; }
        public Assessment assessment { get; set; }
        #endregion

    }
}
