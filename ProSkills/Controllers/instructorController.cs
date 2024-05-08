using Microsoft.AspNetCore.Mvc;

namespace ProSkills.Controllers
{
    public class instructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
