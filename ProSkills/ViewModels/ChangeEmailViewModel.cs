using System.ComponentModel.DataAnnotations;

namespace ProSkills.ViewModels
{
    public class ChangeEmailViewModel
    {
        [Required]
        [EmailAddress]
        public string NewEmail { get; set; }
    }

}
