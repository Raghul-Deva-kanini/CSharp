using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessmentAdmin.Repository.TestHistoryRepository
{
    public class TestHistoryDTO
    {
        public int EmpCode { get; set; }
        public string Name { get; set; }= string.Empty;
        public string AssessmentId { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public string Skill { get; set; } = string.Empty;
        public int NumberOfQuestion { get; set; } 
        public string UserEmail { get; set; }=string.Empty;
        public int NumberOfTopics { get; set; }
        [Column(TypeName = "Date")]
        public DateTime CreatingOn { get; set; }
        [Column(TypeName = "Date")]
        public DateTime CompletedOn { get; set; }
        public int? CorrectAnswer { get;set; }
        public int? WrongAnswer { get; set; }
        public int? SkippedAnswer { get; set; }
    }
}
