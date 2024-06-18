using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProSkills.Models;

namespace ProSkills.Components
{
    public class UserViewComponent : ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserViewComponent(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            return View(user);
        }
    }
}
