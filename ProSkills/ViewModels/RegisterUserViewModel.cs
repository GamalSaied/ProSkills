using Microsoft.AspNetCore.Mvc.Rendering;
using ProSkills.Models.ClientSide.Enumerators;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace ProSkills.ViewModels
{
    public class RegisterUserViewModel
    {
        public string UserName { get; set; }

        public string FullName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

  
        [Required(ErrorMessage = "Please select a country")]
        [Display(Name = "Country")]
     
        public Country Country { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
