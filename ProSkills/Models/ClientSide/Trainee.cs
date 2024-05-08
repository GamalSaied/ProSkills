using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class Trainee
    {
        public int Id { get; set; }      

        public string Name { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        #region foreignkeys
        public ICollection<Enrollment>? enrollments { get; set; }
        public ICollection<Submission> submissions { get; set; }

        #endregion
    }

}
