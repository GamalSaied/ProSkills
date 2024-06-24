using Microsoft.AspNetCore.Mvc;
using ProSkills.Interfaces;
using ProSkills.Models;
using ProSkills.Models.ClientSide;
using System.Diagnostics;

namespace ProSkills.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Category> _categoryRepository;

        public HomeController(ILogger<HomeController> logger, IRepository<Category> categoryRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            ViewBag.FullName = User.Claims.FirstOrDefault(c => c.Type == "FullName")?.Value;
            var categories = _categoryRepository.GetAll();
            return View(categories);
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Courses()
        {
            var categories = _categoryRepository.GetAll();
            return View(categories);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
