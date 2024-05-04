using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProSkills.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public int Phone { get; set; }
        public string country { get; set; }
    }
}
