using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SkillAssessmentAdmin.Models
{
    public class Skill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SkillLevel { get; set; } = string.Empty;
        public ICollection<AddQuestion>? AddQuestions { get; set; }

    }
}
