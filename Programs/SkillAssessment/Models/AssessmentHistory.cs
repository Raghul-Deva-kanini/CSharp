using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessment.Models
{
    public class AssessmentHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 

        [Column(TypeName = "Date")]
        public DateTime DateOfCreation { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfCompletion { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DateOfSubmission { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int? Score { get; set; }
        public int? CorrectAnswer { get; set; }
        public int? WrongAnswer { get; set; }
        public int? SkippedAnswer { get; set; }
        public ICollection<UserAssessment>? UserAssessments { get; set; }
    }
}
