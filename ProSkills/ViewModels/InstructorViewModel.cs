namespace ProSkills.ViewModels
{

    public class InstructorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Unknown Instructor";
        public string ImagePath { get; set; } = "\\ThemeFront\\img\\User.jpg";
        public string Bio { get; set; } = "No bio available.";
        public string Speciallization { get; set; } = "N/A";
    }
}
