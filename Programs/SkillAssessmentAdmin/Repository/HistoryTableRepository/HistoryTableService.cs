
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillAssessmentAdmin.Data;
using SkillAssessmentAdmin.Repository.HistoryTableRepository;
using SkillAssessmentAdmin.Models;

namespace SkillAssessmentAdmin.Repository.HistoryTableRepository
{
    /*public class HistoryTableService:IHistoryTableService
    {
        private readonly SkillAssessmentDbContext _skillAssessmentDbContext;
        public HistoryTableService(SkillAssessmentDbContext skillAssessmentDbContext)
        {
            _skillAssessmentDbContext = skillAssessmentDbContext;
        }
        public async Task<List<HistoryDTO>> GetHistory(string historyName)
        {
            var item = await (from AssessUser in _skillAssessmentDbContext.UserAssessments
                              join Assess in _skillAssessmentDbContext.Assessments on AssessUser.AssessmentId equals Assess.Id
                              join user in _skillAssessmentDbContext.Users on AssessUser.UserId equals user.Id
                              join history in _skillAssessmentDbContext.AssessmentHistorys on AssessUser.AssessmentHistoryId equals history.Id
                              where user.Role == historyName
                              select new HistoryDTO()
                              {
                                  AssessmentId = AssessUser.AssessmentId,
                                  Department = (from UserDept in _skillAssessmentDbContext.Users
                                                join dept in _skillAssessmentDbContext.Departments on UserDept.DepartmentId equals dept.Id
                                                where AssessUser.UserId == user.Id
                                                select dept.DepartmentName).ToQueryString(),

                                  Skill = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                           join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                           join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                           where assmt.Id == AssessUser.AssessmentId
                                           select addqn.Answer).ToQueryString(),

                                  UserEmail = user.Email,
                                  NumberOfTopics = Assess.NumberOfTopics,
                                  DateOfCompletion = history.DateOfCompletion,
                                  Status = history.Status,
                                  EmpId = user.Id,
                                  Photo = user.EmployeeImage,
                                  Name = user.FirstName + " " + user.LastName,
                                  DateOfRequest = history.DateOfCreation
                              }).ToListAsync();
            return item;
        }

        public async Task<List<HistoryDTO>> GetFilterAscending()
        {
            List<HistoryDTO> bufferTable = new List<HistoryDTO>();
            // Populate the bufferTable with DTO objects

            // Sorting in ascending order based on a specific column
            var sortedData = bufferTable.OrderBy(item => item.Department);

            return sortedData.ToList();
        }
        public async Task<List<HistoryDTO>> GetFilterDescending()
        {
            List<HistoryDTO> bufferTable = new List<HistoryDTO>();
            // Populate the bufferTable with DTO objects

            // Sorting in descending order based on a specific column
            var sortedData2 = bufferTable.OrderByDescending(item => item.Department);

            return sortedData2.ToList();
        }
    }*/
}
