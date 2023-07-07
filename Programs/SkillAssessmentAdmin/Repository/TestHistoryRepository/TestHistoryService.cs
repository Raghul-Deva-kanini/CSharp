using Microsoft.EntityFrameworkCore;
using SkillAssessmentAdmin.Data;

namespace SkillAssessmentAdmin.Repository.TestHistoryRepository
{
    public class TestHistoryService:ITestHistoryService
    {
        private readonly SkillAssessmentDbContext _skillAssessmentDbContext;
        public TestHistoryService(SkillAssessmentDbContext skillAssessmentDbContext)
        {
            _skillAssessmentDbContext = skillAssessmentDbContext;
        }

/*        public  Task<TestHistoryDTO?> GetHistory()
        {
            var item =  *//* (from a in _skillAssessmentDbContext.Assessments
                        join u in _skillAssessmentDbContext.Users on a.UserEmail equals u.Email
                        join s in _skillAssessmentDbContext.Skills on a.SkillId equals s.Id
                        where u.Email == "kbrkannan@gmail.com"
                        select new TestHistoryDTO()
                        {
                            EmpCode = u.Id,
                            Name = u.FirstName + " " + u.LastName,
                            AssessmentId = a.Id,
                            Department = (from u in _skillAssessmentDbContext.Users
                                          join d in _skillAssessmentDbContext.EmployeeDepartments on u.EmployeeDepartmentId equals d.Id
                                          where u.Email == "kbrkannan@gmail.com"
                                          select d.EmployeeDepartmentName).ToQueryString(),
                            Designation = u.Designation,
                            Skill = s.SkillLevel,
                            UserEmail = u.Email,
                            NumberOfTopics = a.NumberOfTopics,
                            NumberOfQuestion = a.NumberOfQuestions,
                            CompletedOn = a.DateOfCompletion,
                            CreatingOn = a.DateOfCreation,
                            CorrectAnswer = a.CorrectAnswer,
                            WrongAnswer = a.WrongAnswer,
                            SkippedAnswer = a.SkippedAnswer
                        });*//*
            return item.FirstOrDefaultAsync();
        }*/
    }
}
