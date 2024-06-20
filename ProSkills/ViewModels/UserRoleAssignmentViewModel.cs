using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.ViewModels;

    public class UserRoleAssignmentViewModel
{
    public string UserId { get; set; }
    public string UserName { get; set; }
    public Dictionary<string, bool> Roles { get; set; } // Role name and whether the user has the role
}
