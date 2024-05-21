using System.Drawing;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProSkills.ViewModels;
using Microsoft.AspNetCore.Identity;
using ProSkills.Models;
using Microsoft.Extensions.Configuration.UserSecrets;
using ProSkills.Models.AdminPanel.AccountManger;

namespace ProSkills.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> UserManager, SignInManager<ApplicationUser> SignInManager)
        {

            userManager = UserManager;
            signInManager = SignInManager;
        }

        #region Register
        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserViewModel userfromrequest)
        {
            if (ModelState.IsValid)   //server side validation
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = userfromrequest.UserName;
                user.Email = userfromrequest.Email;
                user.PasswordHash = userfromrequest.Password;
                user.Phone = userfromrequest.Phone;
                //user.ConfirmPassword = userfromrequest.ConfirmPassword;
                user.country = userfromrequest.country;

                IdentityResult Result = await userManager.CreateAsync(user, userfromrequest.Password);

                if (Result.Succeeded == true)
                {
                    //add role Admin
                    //IdentityResult roleResut = await userManager.AddToRoleAsync(user, "Admin");
                    //create cookie //id,username,role
                    await signInManager.SignInAsync(user, false);//session Cookie
                    return RedirectToAction("Login", "Account");
                }
                //fail to save db
                foreach (var error in Result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View("Register", userfromrequest);
        }
        #endregion





        #region Login

        //login
        [HttpGet]
        public IActionResult Login()
        {

            return View("Login");
        }
        //[HttpPost]
        //public async Task<IActionResult> Login(LoginUserViewModel userfromReq)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ApplicationUser userfromdatabase = await userManager.FindByNameAsync(userfromReq.UsreName);
        //        if (userfromdatabase != null)
        //        {
        //            bool found = await userManager.CheckPasswordAsync(userfromdatabase, userfromReq.Password);
        //            if (found == true)
        //            {
        //                //create cookie
        //                await signInManager.SignInAsync(userfromdatabase, userfromReq.RememberMe);
        //                return RedirectToAction("Index", "Home");
        //            }

        //        }
        //        ModelState.AddModelError("", "invalid User");
        //    }
        //    return View("Login");
        //}



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
                        // Add claims for user ID and username
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.NameIdentifier, userfromdatabase.Id),
                            new Claim(ClaimTypes.Name, userfromdatabase.UserName)
                        };

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        // Sign in with the claims
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), new AuthenticationProperties { IsPersistent = userfromReq.RememberMe });
                        //await signInManager.SignInAsync(userfromdatabase, userfromReq.RememberMe);
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError("", "Invalid User");
            }
            return View("Login");
        }
        #endregion



        #region logout

        //logout
        //destroy the cookie
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> logout()
        {
            // Using SignInManager
            await signInManager.SignOutAsync();
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
                var user = await userManager.FindByEmailAsync(modelformreq.Email);
                if (user is not null)
                {
                    var token = userManager.GeneratePasswordResetTokenAsync(user); //token valid for this user only one time
                    var passwordresetLink = Url.Action("ResetPassword", "Account", new{Email=user.Email,token=token});

                    var email = new Email()
                    {
                        subject = "Reset password",
                        body = passwordresetLink,
                        To = user.Email


                    };
                    EmailSettings.Sendemail(email);
                    RedirectToAction("CheckyourInbox");
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
