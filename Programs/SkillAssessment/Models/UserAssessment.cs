using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessment.Models
{
    public class UserAssessment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Assessment")]
        public string? AssessmentId { get; set; }
        [ForeignKey("AssessmentHistory")]
        public int AssessmentHistoryId { get; set; }
        [ForeignKey("EmailHistory")]
        public int EmailHistoryId { get; set; }
    }
}
