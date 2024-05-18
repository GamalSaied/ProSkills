using Microsoft.AspNetCore.Mvc.Rendering;
using ProSkills.Models.ClientSide.Enumerators;
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

  
        [Required(ErrorMessage = "Please select a country")]
        [Display(Name = "Country")]
        public string country { get; set; }
        //public Country SelectedCountry { get; set; }

        //public List<SelectListItem> Countries { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
