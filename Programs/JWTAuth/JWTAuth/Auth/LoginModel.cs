using System.ComponentModel.DataAnnotations;

namespace JWTAuth.Auth
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Pwd required")]
        public string? Password { get; set; }
    }
}
