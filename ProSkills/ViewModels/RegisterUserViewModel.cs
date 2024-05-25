using Microsoft.AspNetCore.Mvc.Rendering;
using ProSkills.Models.ClientSide.Enumerators;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace ProSkills.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage = "Please enter your full name")]
        public string FullName { get; set; }

   

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public string Phone {  get; set; }


        [Required(ErrorMessage = "Please select your country")]
        public Country Country { get; set; }
    }

}

