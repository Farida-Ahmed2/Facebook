using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HouseMata.ViewModels
{
    public class LoginViewModel
    {
            [Required(ErrorMessage = "Required  !")]
            [EmailAddress(ErrorMessage = "Invalid Email Address !")]
            public string Username { get; set; }
            [Required(ErrorMessage = "Required  !")]
            public string Password { get; set; }
    }
}