using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SkillAssessment.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessmentAdmin.Models
{
    public class EmailHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string AssessmentId { get; set; } = string.Empty;
        [Column(TypeName = "Date")]
        public DateTime SentTime { get; set; }
        public ICollection<UserAssessment>? UserAssessments { get; set; }
    }
}
