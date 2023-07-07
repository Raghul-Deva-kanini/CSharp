using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SkillAssessmentAdmin.Models
{
    public class UserRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey("Assessment")]
        public string? AssessmentId { get; set; }

        public int NumberOfQuestions { get; set; } 

        [Column(TypeName = "Date")]
        public DateTime DateOfCompletion { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DateOfRequest { get; set; }
        public int TotalTime { get; set; }
        public Boolean? IsChecked { get; set; }
    }
}
