using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SkillAssessmentAdmin.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessmentAdmin.Models
{
    public class EmailHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey("Assessment")]
        public string AssessmentId { get; set; } = string.Empty;
        [Column(TypeName = "Date")]
        public DateTime SentTime { get; set; }
    }
}
