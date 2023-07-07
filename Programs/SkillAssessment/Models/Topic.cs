using SkillAssessment.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessmentAdmin.Models
{
    public class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TopicName { get; set; } = string.Empty;
        public byte[]? TopicImage { get; set; }
        public ICollection<AddQuestion>? AddQuestions { get; set; }
    }
}
