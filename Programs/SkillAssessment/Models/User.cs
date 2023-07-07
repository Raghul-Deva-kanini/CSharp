using SkillAssessment.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace SkillAssessmentAdmin.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        public byte[]? Email { get; set; }
        public byte[]? EmployeeImage { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public string EducationLevel { get; set; } = string.Empty;
        public string Role { get; set; }=string.Empty;
        public string Designation { get; set; } = string.Empty;
        public int? PhoneNumber { get; set; } 
        public string Location { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public byte[]? Password { get; set; }
        public byte[]? HashKey { get; set; }
        public ICollection<UserAssessment>? UserAssessments { get; set; }
    }
}
