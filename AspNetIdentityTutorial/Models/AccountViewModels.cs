﻿using System.ComponentModel.DataAnnotations;

namespace AspNetIdentityTutorial.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="The {0} must be at least {2} character long.", MinimumLength =6)]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage ="The Password and Confirmation Password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}