using Microsoft.AspNetCore.Mvc.Rendering;
namespace ProSkills.ViewModels
{
    public class AddPointsViewModel
    {
        public string TraineeEmail { get; set; }
        public string CourseName { get; set; }
        public int Points { get; set; } = 0;

        public IEnumerable<SelectListItem>? Trainees { get; set; }
        public IEnumerable<SelectListItem>? Courses { get; set; }
    }

}
