using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HouseMata.ViewModels
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Required  !")]
        [StringLength(20, ErrorMessage = "FirstName Length Exceeded  (Only 20 chars Allowed)!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required  !")]
        [StringLength(20, ErrorMessage = "LastName Length Exceeded  (Only 20 chars Allowed)!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required  !")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Required  !")]
        public string City { get; set; }

        [Required(ErrorMessage = "Required  !")]
        [StringLength(12, ErrorMessage = "Phone Length Exceeded  (Only 12 chars Allowed)!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Required  !")]
        [EmailAddress(ErrorMessage = "Invalid Email Address !")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required  !")]
        public string ProfileImage { get; set; }

        [Required(ErrorMessage = "Required  !")]
        public string HeaderImage { get; set; }

        [Required(ErrorMessage = "Required  !")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Required  !")]
        [StringLength(15, MinimumLength = 8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Required  !")]
        [StringLength(15, MinimumLength = 8)]
        [Compare("Password", ErrorMessage = "Password Didn't Match  !")]
        public string ConfirmPassword { get; set; }

        public string Message { get; set; }
    }
}