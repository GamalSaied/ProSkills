using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models.AdminPanel.InstructorManger;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;
using System.Collections.Generic;

namespace ProSkills.Controllers
{
    public class CourseController : Controller
    {
        private IRepository<Course> _courseRepository;

        public CourseController(IRepository<Course> CourseRepository)
        {
            _courseRepository = CourseRepository;
        }

        //Filter By Instractor id
        public IActionResult index(int id)
        {
            
            List<Course> Courses = _courseRepository.GetAll();
            //List<Course> instructorCourses 
            return View("index", Courses);

        }

    }
}
