using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;

namespace ProSkills.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Category> _CategoryRepository;
      
        public CategoryController(IRepository<Category> CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
