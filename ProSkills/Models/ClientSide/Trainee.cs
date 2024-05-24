using ProSkills.Models.ClientSide.Enumerators;

namespace ProSkills.Models.ClientSide
{
    public class Trainee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public Country? country  { get; set; }
         
        public string? Bio { get; set; }
        public string? CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public List<CourseTrainee>? Courses { get; set; }
    }
}
