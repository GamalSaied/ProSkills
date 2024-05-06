using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProSkills.Models
{
    public class ApplicationUser: IdentityUser
    {
       
        public String Email { get; set; }

        public int Phone { get; set; }
        public string country { get; set; }
    }
}
