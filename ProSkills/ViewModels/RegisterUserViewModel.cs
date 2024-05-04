using System.ComponentModel.DataAnnotations;

namespace ProSkills.ViewModels
{
    public class RegisterUserViewModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        [DataType(DataType.Text)]
        public string country { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }
        
    }
}
