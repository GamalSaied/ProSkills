using Microsoft.AspNetCore.Mvc;

namespace ProSkills.Controllers
{
    public class AdminController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
    }

}