namespace ProSkills.Models.AdminPanel.Instractor
{
    public class instructor
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Bio { get; set; }
        public string CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

    }
}
