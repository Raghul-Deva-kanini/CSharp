using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace SkillAssessmentAdmin.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public ICollection<User>? Users { get; set; }
        public ICollection<Topic>? Topics { get; set; }
    }
}
