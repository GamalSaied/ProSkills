using ProSkills.Models.ClientSide.Enumerators;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class Assessment
    {
        public int Id { get; set; }
        public AssessmentType assessmentType { get; set; }

        public int MaxScore { get; set; }

        public DateTime DueDate { get; set; }

        public string Weight { get; set; }  ///Contribution to the final course grade



        [ForeignKey("ModuleId")]
        public int ModuleId { get; set; }
        public Module module { get; set; }

        public ICollection<Submission> submissions  { get; set;}



    }
}
