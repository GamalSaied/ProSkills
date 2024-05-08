using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using ProSkills.Repository;

namespace ProSkills.Controllers
{
    public class CategoryController : Controller
    {
        ICourseRepository CourseRepository;
        public DepartmentController(IRepository _InstructorRepository, IDepartmentRepository _DepartmentRepository, ICourseRepository _CourseRepository)
        {
            InstructorRepository = _InstructorRepository;
            DepartmentRepository = _DepartmentRepository;
            CourseRepository = _CourseRepository;
        }
        public CategoryController(IRepository<Category> )
        {
                
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
