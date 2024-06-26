﻿using System.ComponentModel.DataAnnotations;

namespace ProSkills.ViewModels
{
    public class LoginUserViewModel
    {
       
        public string? Username { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
