using Microsoft.AspNetCore.Identity;
using ProSkills.Models.ClientSide.Enumerators;


namespace ProSkills.Models.ClientSide
{
    public class User : IdentityUser
    {

        public UserType UserType { get; set; }

        public Country Country { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? ModifiedAt { get; set; }
        public string? Image { get; set; }

        public string? AddressLine { get; set; }

    }
}
