using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProSkills.ViewComponents
{
    public class CourseDropdownViewComponent : ViewComponent
    {
        private readonly IRepository<Course> _courseRepository;

        public CourseDropdownViewComponent(IRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var courses = _courseRepository.GetAll().OrderBy(c => c.Name).ToList();
            return View(courses);
        }
    }
}
