using ProSkills.Models.ClientSide;

namespace ProSkills.Models.AdminPanel.InstructorManger
{

    public class instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Bio { get; set; }
        public string? Speciallization { get; set; }

        #region ForeignKeys 

        #endregion
        public string CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

    }
}
