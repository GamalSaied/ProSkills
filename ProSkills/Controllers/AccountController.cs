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
using ProSkills.Helpers;
using ProSkills.Models.ClientSide.Enumerators;
using System;

namespace ProSkills.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITraineeRepository _traineeRepository;
        private readonly IWebHostEnvironment _environment;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ITraineeRepository traineeRepository, IWebHostEnvironment environment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _traineeRepository = traineeRepository;
            _environment = environment;

        }


        [HttpPost]
        public async Task<IActionResult> UploadProfilePicture(IFormFile croppedImage)
        {
            if (croppedImage == null || croppedImage.Length == 0)
            {
                return Json(new { success = false, message = "Invalid image file" });
            }

            try
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, "images/profiles");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(croppedImage.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await croppedImage.CopyToAsync(fileStream);
                }

                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    user.ProfilePictureUrl = "/images/profiles/" + uniqueFileName;
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return Json(new { success = true, imageUrl = user.ProfilePictureUrl });
                    }
                    else
                    {
                        return Json(new { success = false, message = "Failed to update user profile" });
                    }
                }
                else
                {
                    return Json(new { success = false, message = "User not found" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }



        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var model = new ApplicationUser
            {
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                FullName = user.FullName,
                City = user.City,
                Country = user.Country,
                ProfilePictureUrl = user.ProfilePictureUrl
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> EditProfile(ApplicationUser model)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound("User not found");
            }

            user.FullName = model.FullName;
            user.PhoneNumber = model.PhoneNumber;
            user.Country = model.Country;
            user.City = model.City;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Profile");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View("Profile", user);
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
            return RedirectToAction("Index", "Home");
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

