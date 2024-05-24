using Microsoft.AspNetCore.Identity;
using ProSkills.Models.ClientSide.Enumerators;
using System.ComponentModel.DataAnnotations;

namespace ProSkills.Models
{
    public class ApplicationUser: IdentityUser
    {
       
        public String Email { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public Country Country { get; set; }
    }
}
