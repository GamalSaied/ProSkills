using Microsoft.AspNetCore.Mvc;

namespace ProSkills.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryController()
        {
                
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
