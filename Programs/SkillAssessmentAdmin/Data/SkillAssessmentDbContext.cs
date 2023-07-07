
using Microsoft.EntityFrameworkCore;
using SkillAssessmentAdmin.Models;

namespace SkillAssessmentAdmin.Data
{
    public class SkillAssessmentDbContext:DbContext
    {
        public SkillAssessmentDbContext(DbContextOptions<SkillAssessmentDbContext> options) : base(options) { }

        public DbSet<AssessmentHistory> AssessmentHistorys { get; set; }
        public DbSet<UserAssessment> UserAssessments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<AddQuestion> AddQuestions { get; set; }
        public DbSet<EmailHistory> EmailHistory { get; set; }
        public DbSet<QuestionPage> QuestionPages { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }

        public DbSet<UserRequest> UserRequests { get; set; }

    }
}
