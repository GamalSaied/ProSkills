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

    }
    public class TreeDatas
    {
        public string nodeId { get; set; }
        public string nodeText { get; set; }
        public string iconCss { get; set; }
        public bool hasChild { get; set; }
        public string pid { get; set; }
    }
}