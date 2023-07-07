using SkillAssessmentAdmin.Models;

namespace JWTAuthenticationApp.Models.DTO
{
    public class UserRegisterDTO : User
    {
        public string? UserEmailClear { get; set; }
        public string? PasswordClear { get; set; }
    }
}
