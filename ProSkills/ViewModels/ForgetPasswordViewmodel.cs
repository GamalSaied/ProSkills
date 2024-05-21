using System.ComponentModel.DataAnnotations;

namespace ProSkills.ViewModels
{
    public class ForgetPasswordViewmodel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage="Invalid Email ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
