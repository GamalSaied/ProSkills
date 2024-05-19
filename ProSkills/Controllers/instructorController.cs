using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProSkills.Interfaces;
using ProSkills.Models.AdminPanel.InstructorManger;
using ProSkills.Repository;
namespace ProSkills.Controllers;

public class InstructorController : Controller
{

    private IRepository<instructor> _instructorRepository;

    public InstructorController(IRepository<instructor> InstructorRepository)
    {
        _instructorRepository = InstructorRepository;
    }

    public IActionResult index()
    {
        List<instructor> instructors = _instructorRepository.GetAll();

        //return View("Showall", instractorList); //View Index ,Model List<Department>
        return View("index", instructors);

    }
}
