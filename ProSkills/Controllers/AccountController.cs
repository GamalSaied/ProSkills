using System.Drawing;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProSkills.ViewModels;
using ProSkills.Models;
using ProSkills.Models.ClientSide;
using ProSkills.Interfaces;
using System.Threading.Tasks;
using ProSkills.Models.AdminPanel.AccountManger;

namespace ProSkills.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITraineeRepository _traineeRepository;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ITraineeRepository traineeRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _traineeRepository = traineeRepository;
        }

      

        #region Register

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserViewModel userFromRequest)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    FullName = userFromRequest.FullName,
                    Email = userFromRequest.Email,
                    Phone = userFromRequest.Phone,
                    Country = userFromRequest.Country,
                    UserName = userFromRequest.Email,

                };

                var result = await _userManager.CreateAsync(user, userFromRequest.Password);

                if (result.Succeeded)
                {
                    var trainee = userFromRequest.ToTrainee();
                    trainee.Email = user.Email;
                    trainee.Name = user.FullName;
                    trainee.Country = user.Country;
                   
                    _traineeRepository.Insert(trainee);
                    _traineeRepository.Save();
                  
                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction(nameof(Login));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(userFromRequest);
        }

        #endregion

        #region Login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel userFromReq)
        {
            if (ModelState.IsValid)
            {
                // Check if user exists
                ApplicationUser userFromDB = await _userManager.FindByNameAsync(userFromReq.Email);
                if (userFromDB != null)
                {
                    // Verify password
                    bool found = await _userManager.CheckPasswordAsync(userFromDB, userFromReq.Password);
                    if (found)
                    {
                        // Sign in the user
                        await _signInManager.SignInAsync(userFromDB, userFromReq.RememberMe);

                        // Redirect to the desired page
                        return RedirectToAction("Index", "Home");
                    }
                }

                // Add error message if login fails
                ModelState.AddModelError("", "Invalid Account");
            }

            return View("Login", userFromReq);
        }

        #endregion

        #region Logout

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }


        #endregion

        #region Forget Password

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(ForgetPasswordViewmodel modelformreq)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(modelformreq.Email);
                if (user is not null)
                {
                    var token = await _userManager
                        .GeneratePasswordResetTokenAsync(user); //token valid for this user only one time
                    var passwordresetLink = Url.Action("ResetPassword", "Account",
                        new { Email = user.Email, token = token });

                    var email = new Email
                    {
                        subject = "Reset password",
                        body = passwordresetLink,
                        To = user.Email
                    };

                    EmailSettings.Sendemail(email);
                    return RedirectToAction("CheckyourInbox");
                }

                ModelState.AddModelError("", "Email is not found");
            }

            return View();
        }

        public IActionResult CheckyourInbox()
        {
            return View();
        }

        #endregion

    }
}

