using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessmentAdmin.Models
{
    public class AssessmentHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 

        [Column(TypeName = "Date")]
        public DateTime? DateOfSubmission { get; set; }
        public string Status { get; set; } = string.Empty;
        public int? Score { get; set; }
        public int? CorrectAnswer { get; set; }
        public int? WrongAnswer { get; set; }
        public int? SkippedAnswer { get; set; }
        public int? Points { get; set; }
        public ICollection<UserAssessment>? UserAssessments { get; set; }
    }
}
