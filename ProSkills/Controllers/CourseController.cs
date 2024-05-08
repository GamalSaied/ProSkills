using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.AdminPanel.InstructorManger;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;

namespace ProSkills.Controllers
{
    public class CourseController : Controller
    {
        private IRepository<Course> _courseRepository;

        public CourseController(IRepository<Course> CourseRepository)
        {
            _courseRepository = CourseRepository;
        }

        // Filter By Instractor id 
        public IActionResult index(int id)
        {
            //List<InstructorCourse> Courses = _courseRepository.GetAll();

            //return View("Showall", instractorList); //View Index ,Model List<Department>
            //return View("index", instructors);

        }

    }
}
