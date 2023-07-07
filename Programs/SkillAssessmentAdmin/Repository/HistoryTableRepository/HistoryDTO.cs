using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessment.Repository.HistoryTableRepository
{
    public class HistoryDTO
    {
        public string AssessmentId { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Skill { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int EmpId { get; set; }
        public byte[]? Photo { get; set; }
        public string? UserEmail { get; set; }
        public int NumberOfTopics { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfCompletion { get; set; }
        public string Status { get; set; } = string.Empty;
        [Column(TypeName = "Date")]
        public DateTime DateOfRequest { get; set; }
    }
}
