using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProSkills.ViewModels;
using Microsoft.AspNetCore.Identity;
using ProSkills.Models;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace ProSkills.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> UserManager,SignInManager<ApplicationUser> SignInManager)
        {
          
            userManager = UserManager;
            signInManager = SignInManager;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserViewModel userfromrequest)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = userfromrequest.UserName;
                user.Email = userfromrequest.Email;
                user.PasswordHash = userfromrequest.Password;
                user.Phone = userfromrequest.Phone;
                //user.ConfirmPassword = userfromrequest.ConfirmPassword;
                user.country= userfromrequest.SelectedCountry;

                IdentityResult Result = await userManager.CreateAsync(user,userfromrequest.Password);

                if (Result.Succeeded == true)
                {
                    //add role Admin
                    //IdentityResult roleResut = await userManager.AddToRoleAsync(user, "Admin");
                    //create cookie //id,username,role
                    await signInManager.SignInAsync(user, false);//session Cookie
                    return RedirectToAction("Index", "Account");
                }
                //fail to save db
                foreach (var item in Result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

            }
            return View("Register", userfromrequest);   
        }

        //login
        [HttpGet]
        public IActionResult Login()
        {

            return View("Login");
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel userfromReq)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser userfromdatabase = await userManager.FindByNameAsync(userfromReq.UsreName);
                if (userfromdatabase != null)
                {
                    bool found = await userManager.CheckPasswordAsync(userfromdatabase, userfromReq.Password);
                    if (found == true)
                    {
                        //create cookie
                         await signInManager.SignInAsync(userfromdatabase, userfromReq.RememberMe);
                        return RedirectToAction("Index", "Instructor");
                    }

                }
                ModelState.AddModelError("", "invalid User");
            }
            return View("Login");
        }


        //logout
        //destroy the cookie
        public async Task<IActionResult> logout()
        {
             await signInManager.SignOutAsync();
             return RedirectToAction("Login");
        }
    }
}
