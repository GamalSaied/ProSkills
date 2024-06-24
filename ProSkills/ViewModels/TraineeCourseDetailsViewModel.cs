using ProSkills.Models.ClientSide.Enumerators;

namespace ProSkills.ViewModels
{
    public class TraineeCourseDetailsViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string CourseName { get; set; }
        public Level Level { get; set; }
        public double CompletionRatio { get; set; }
        public int Points { get; set; }
        public int Rank { get; set; }
    }

}