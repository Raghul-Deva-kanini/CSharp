using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessmentAdmin.Models
{
    public class UserAssessment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("User")]
        public string? UserId { get; set; }
        [ForeignKey("Assessment")]
        public string? AssessmentId { get; set; }
        public int NumberOfTopics { get; set; }
        public int NumberOfQuestions { get; set; }
        public int? TotalTime { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DateOfCreation { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DateOfCompletion { get; set; }
        public string? Description { get; set; }

        [ForeignKey("AssessmentHistory")]
        public int? AssessmentHistoryId { get; set; }
    }
}
