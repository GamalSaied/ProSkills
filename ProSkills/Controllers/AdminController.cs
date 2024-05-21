using Microsoft.AspNetCore.Mvc;

namespace ProSkills.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
