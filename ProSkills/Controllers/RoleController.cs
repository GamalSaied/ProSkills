using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProSkills.Models;
using ProSkills.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProSkills.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> ManageUserRoles()
        {
            var users = _userManager.Users.ToList();
            var roles = _roleManager.Roles.ToList();

            var model = new List<UserRoleAssignmentViewModel>();

            foreach (var user in users)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var roleAssignments = new Dictionary<string, bool>();

                foreach (var role in roles)
                {
                    roleAssignments[role.Name] = userRoles.Contains(role.Name);
                }

                model.Add(new UserRoleAssignmentViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    Roles = roleAssignments
                });
            }

            ViewBag.Roles = roles;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ManageUserRoles(List<UserRoleAssignmentViewModel> model)
        {
            foreach (var userRoleAssignment in model)
            {
                var user = await _userManager.FindByIdAsync(userRoleAssignment.UserId);
                if (user == null)
                {
                    continue;
                }

                foreach (var roleAssignment in userRoleAssignment.Roles)
                {
                    if (roleAssignment.Value) // Add role
                    {
                        if (!await _userManager.IsInRoleAsync(user, roleAssignment.Key))
                        {
                            await _userManager.AddToRoleAsync(user, roleAssignment.Key);
                        }
                    }
                    else // Remove role
                    {
                        if (await _userManager.IsInRoleAsync(user, roleAssignment.Key))
                        {
                            await _userManager.RemoveFromRoleAsync(user, roleAssignment.Key);
                        }
                    }
                }
            }

            return RedirectToAction("ManageUserRoles");
        }
    }
}
