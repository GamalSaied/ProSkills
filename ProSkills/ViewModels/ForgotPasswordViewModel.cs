using System.ComponentModel.DataAnnotations;

namespace ProSkills.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

}
