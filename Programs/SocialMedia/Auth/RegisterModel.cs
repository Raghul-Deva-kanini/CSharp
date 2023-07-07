using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Auth;

public class RegisterModel
{
    [Required(ErrorMessage = "Username required")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Email required")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Pwd required")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Role Required")]
    public string Roles { get; set; } = string.Empty;
}
