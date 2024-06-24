using Microsoft.AspNetCore.Mvc.Rendering;
namespace ProSkills.ViewModels
{
    public class AddPointsViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string CourseName { get; set; }
        public int Points { get; set; }
    }


}
