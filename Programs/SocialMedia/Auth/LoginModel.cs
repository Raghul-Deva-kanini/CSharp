﻿using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Auth
{
    public class LoginModel
    {
        [Required(ErrorMessage = "UserName Required")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; } = string.Empty;

        
    }
}

