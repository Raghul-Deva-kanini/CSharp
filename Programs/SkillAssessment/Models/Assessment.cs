using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using SkillAssessment.Models;

namespace SkillAssessmentAdmin.Models
{
    public class Assessment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }= string.Empty;
        public int NumberOfTopics { get; set; }
        public int NumberOfQuestions { get; set; }

        public ICollection<QuestionPage>? QuestionPages { get; set; }
        public ICollection<UserAssessment>? UserAssessments { get; set; }

    }
}
