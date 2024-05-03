using Microsoft.AspNetCore.Mvc;
using ProSkills.ViewModels;

namespace ProSkills.Controllers
{
    public class AccountController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View(Register);
        }
        [HttpPost]
        public IActionResult Register(RegisterUserViewModel userfromrequest)
        {
           if(ModelState.IsValid)
            {

            }
        }
    }
}
