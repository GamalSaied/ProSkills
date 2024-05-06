using System.ComponentModel.DataAnnotations;

namespace ProSkills.ViewModels
{
    public class LoginUserViewModel
    {
        public string UsreName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
