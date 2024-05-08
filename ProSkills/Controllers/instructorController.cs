using Microsoft.AspNetCore.Mvc;

namespace ProSkills.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
