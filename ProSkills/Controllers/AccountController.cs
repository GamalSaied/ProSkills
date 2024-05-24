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
        private readonly IRepository<Trainee> _traineeRepository;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            IRepository<Trainee> traineeRepository)
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
        public async Task<IActionResult> Register(RegisterUserViewModel userfromrequest)
        {
            if (ModelState.IsValid) // server side validation
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = userfromrequest.Email,
                    Email = userfromrequest.Email,
                    PhoneNumber = userfromrequest.Phone,
                  Country = userfromrequest.Country
                };

                var result = await _userManager.CreateAsync(user, userfromrequest.Password);

                if (result.Succeeded)
                {
                    // Map to Trainee
                    var trainee = userfromrequest.ToTrainee();

                    // Save Trainee to Database
                    _traineeRepository.Insert(trainee);
                    _traineeRepository.Save();

                    await _signInManager.SignInAsync(user, false); // session Cookie
                    return RedirectToAction("Login", "Account");
                }

                    // Fail to save db
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
             

               
            }
            return View("Register", userfromrequest);
        }

        #endregion

        #region Login

        [HttpGet]
            public IActionResult Login()
            {
                return View("Login");
            }

            [HttpPost]
            public async Task<IActionResult> Login(LoginUserViewModel model)
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.FindByNameAsync(model.UserName);
                    if (user != null)
                    {
                        var result =
                            await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }

                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }

                return View(model);
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

