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
using Syncfusion.EJ2.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using ProSkills.Repository;

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

        [Authorize]
        public async Task<IActionResult> Programs()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var trainee = _traineeRepository.GetTraineeByEmail(user.Email);
            if (trainee == null || trainee.IsDeleted)
            {
                return RedirectToAction("Index", "Home");
            }

            var courses = trainee.Courses?
                .Where(tc => !tc.Course.IsDeleted)
                .Select(tc => new CourseViewModel
                {
                    Id = tc.Course.Id,
                    Title = tc.Course.Name,
                    Description = tc.Course.Description,
                    Duration = tc.Course.Hours ?? 0,
                    StudentCount = tc.Course.NumberOfTrainees ?? 0,
                    Rating = tc.Course.Rating,
                    ReviewCount = tc.Course.ReviewCount,
                    StartAt = tc.Course.StartAt,
                    EndAt = tc.Course.EndAt,
                    Location = tc.Course.Location,
                    ImagePath = tc.Course.CourseImagePath,
                    Chapters = tc.Course.Chapters.Select(c => new ChapterViewModel
                    {
                        Id = c.Id,
                        Title = c.Title,
                        Description = c.Description
                    }).ToList(),
                    Instructor = new InstructorViewModel
                    {
                        Id = tc.Course.Instructor.Id,
                        Name = tc.Course.Instructor.Name,
                        ImagePath = tc.Course.Instructor.ImagePath,
                        Bio = tc.Course.Instructor.Bio,
                        Speciallization = tc.Course.Instructor.Speciallization
                    },
                    CompletionRatio = tc.CompletionRatio
                }).ToList() ?? new List<CourseViewModel>();

            var viewModel = new MyCoursesViewModel
            {
                User = user,
                Courses = courses
            };

            return View(viewModel);
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
                        var trainee = _traineeRepository.GetTraineeByEmail(user.Email);
                        if (trainee != null)
                        {
                            trainee.ProfilePictureUrl = user.ProfilePictureUrl;
                            _traineeRepository.Update(trainee);
                            _traineeRepository.Save();
                        }

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
                Phone = user.Phone,
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
            user.Phone = model.Phone;
            user.Country = model.Country;
            user.City = model.City;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                var trainee = _traineeRepository.GetTraineeByEmail(user.Email);
                if (trainee != null)
                {
                    trainee.Name = user.FullName;
                    trainee.Phone = user.Phone;
                    trainee.Country = user.Country;

                    _traineeRepository.Update(trainee);
                    _traineeRepository.Save();
                }

                return RedirectToAction("Profile");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View("Profile", user);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Profile", model);
            }

            try
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("Login", "Account");
                }

                var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                if (!changePasswordResult.Succeeded)
                {
                    foreach (var error in changePasswordResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View("Profile", model);
                }

                await _signInManager.RefreshSignInAsync(user);
                return RedirectToAction("Profile");
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., using a logging framework)
                ModelState.AddModelError(string.Empty, "An error occurred while changing the password. Please try again later.");
                // Optionally, log the detailed exception message for debugging purposes:
                // _logger.LogError(ex, "Error occurred while changing password for user {UserId}", user?.Id);
                return View("Profile", model);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeEmail(ChangeEmailViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "The new email is not valid.");
                return View("Profile", await GetProfileModelWithErrors());
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            user.UserName = model.NewEmail;
            user.Email = model.NewEmail;
            var setUserNameResult = await _userManager.UpdateAsync(user);
            if (!setUserNameResult.Succeeded)
            {
                foreach (var error in setUserNameResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View("Profile", await GetProfileModelWithErrors());
            }

            var trainee = _traineeRepository.GetTraineeByEmail(user.Email);
            if (trainee != null)
            {
                trainee.Email = user.Email;
                _traineeRepository.Update(trainee);
                _traineeRepository.Save();
            }

            await _signInManager.RefreshSignInAsync(user);
            return RedirectToAction("Profile");
        }

        // Helper method to get the Profile model with errors
        private async Task<ApplicationUser> GetProfileModelWithErrors()
        {
            var user = await _userManager.GetUserAsync(User);
            return new ApplicationUser
            {
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.Phone,
                FullName = user.FullName,
                City = user.City,
                Country = user.Country,
                ProfilePictureUrl = user.ProfilePictureUrl
            };
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
                    UserName = userFromRequest.Email,
                    Phone = userFromRequest.Phone,
                    Country = userFromRequest.Country,
                    ProfilePictureUrl = "/themefront/img/user.jpg" // Default profile picture
                };

                var result = await _userManager.CreateAsync(user, userFromRequest.Password);

                if (result.Succeeded)
                {
                    var trainee = new Trainee
                    {
                        Name = user.FullName,
                        Email = user.Email,
                        Phone = user.Phone,
                        Country = user.Country,
                        CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        IsDeleted = false
                    };

                    _traineeRepository.Insert(trainee);
                    _traineeRepository.Save();

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





        #region Myforgetpassword
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgetPasswordViewmodel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Assuming email normalization is needed
            string normalizedEmail = model.Email;
            var user = await _userManager.FindByEmailAsync(normalizedEmail);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid email address.");
                return View(model);
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var resetLink = Url.Action("ResetPassword", "Account", new { token, email = model.Email }, Request.Scheme);

            string emailSubject = "Password Reset";
            string emailBody = $"Please reset your password by clicking here: <a href='{resetLink}'>link</a>";

            await EmailSettings.SendEmailAsync(new Email
            {
                To = model.Email,
                Subject = emailSubject,
                Body = emailBody
            });

            return RedirectToAction("ForgotPasswordConfirmation");
        }

        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        public IActionResult ResetPassword(string token, string email)
        {
            var model = new ResetPasswordViewModel { Token = token, Email = email };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid request.");
                return View();
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("ResetPasswordConfirmation");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View();
        }

        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }
        #endregion



    }
}



    

