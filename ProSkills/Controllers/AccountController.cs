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
                    UserName = userFromRequest.Email
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
                  
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction(nameof(Login));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
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
        public async Task<IActionResult> Login(LoginUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    // Retrieve the user and trainee information
                    var user = await _userManager.FindByEmailAsync(model.UserName);

                    if (user == null)
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        return View(model);
                    }

                    // Retrieve the trainee information
                    var trainee = _traineeRepository.GetTraineeByEmail(user.Email);


                    if (trainee != null)
                    {
                        // Redirect to the Course/TraineeCourseList view with the traineeId as a query parameter
                        return RedirectToAction("TraineeCourseList", "Course", new { traineeId = trainee.Id });
                    }

                    return RedirectToAction("Index", "Home");
                }

                if (result.IsLockedOut)
                {
                    ModelState.AddModelError(string.Empty, "User account locked out.");
                    return View(model);
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }

            return View(model);
        }
        //[HttpPost]
        //public async Task<IActionResult> Login(LoginUserViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);

        //        if (result.Succeeded)
        //        {
        //            var user = await _userManager.FindByEmailAsync(model.UserName);
        //            if (user != null)
        //            {
        //                var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, user.UserName),
        //            new Claim("FullName", user.FullName) // Add FullName claim
        //        };

        //                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        //                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

        //                // Assuming user.TraineeId contains the traineeId
        //                string traineeId = user.Id; // Replace with the correct property or method to get traineeId
        //                return RedirectToAction("TraineeCourseList", "Course", new { traineeId = traineeId });
        //            }

        //            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        //        }
        //    }

        //    return View(model);
        //}


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

