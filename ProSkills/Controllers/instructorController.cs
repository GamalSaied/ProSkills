using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProSkills.Interfaces;
using ProSkills.Models.AdminPanel.Instractor;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;

namespace ProSkills.Controllers
{
    public class InstructorController : Controller
    {

        private IRepository<instructor> _instructorRepository;

        public InstructorController(IRepository<instructor> InstructorRepository)
        {
            _instructorRepository = InstructorRepository;
        }

        //public IActionResult index()
        //{
        //    List<Course> courses = /*_instructorRepository*/.GetAll();

        //    //return View("Showall", instractorList); //View Index ,Model List<Department>
            
        //}
    }
}
