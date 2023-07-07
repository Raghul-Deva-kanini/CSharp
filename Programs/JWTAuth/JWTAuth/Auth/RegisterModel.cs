using System.ComponentModel.DataAnnotations;

namespace JWTAuth.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Username required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Email required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Pwd required")]
        public string? Password { get; set; }
    }
}
