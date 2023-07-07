using SkillAssessmentAdmin.Repository.TestHistoryRepository;
using Microsoft.AspNetCore.Mvc;

namespace SkillAssessmentI.Controllers
{
    [Route("TestHistory")]
    [ApiController]
    public class TestHistoryController:ControllerBase
    {
/*        private readonly ITestHistoryService _historyService;
        public TestHistoryController(ITestHistoryService historyService)
        {
            _historyService = historyService;
        }
        [HttpGet("History")]
        public async Task<ActionResult<TestHistoryDTO>> GetHistory()
        {
            var item =  await _historyService.GetHistory();
            return Ok(item);
        }*/
    }
}
