using Microsoft.AspNetCore.Identity;

namespace ProSkills.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Address { get; set; }

    }
}
