using Microsoft.AspNetCore.Mvc;
using SkillAssessmentAdmin.Repository.HistoryTableRepository;
using SkillAssessmentAdmin.Models;

namespace SkillAssessment.Controllers
{
    [Route("HistoryTable")]
    [ApiController]
    public class HistoryTableController:ControllerBase
    {
        private readonly IHistoryTableService _historyTableService;
        public HistoryTableController(IHistoryTableService historyTableService)
        {
            _historyTableService = historyTableService;
        }
/*        [HttpGet("HistoryDetails")]
        public async Task<ActionResult<List<HistoryDTO>>> GetHistory(string historyName)
        {
           var item= await _historyTableService.GetHistory(historyName);
            return Ok(item);
        }*/
        /*        [HttpGet("EmployeeHistory")]
                public async Task<ActionResult<List<EmployeeHistoryDTO>>> GetEmployeeHistory()
                {
                    var item = await _historyTableService.GetEmployeeHistory();
                    return Ok(item);
                }
                [HttpGet("RequestHistory")]
                public async Task<ActionResult<List<RequestHistoryDTO>>> GetRequestHistory()
                {
                    var item = await _historyTableService.GetRequestHistory();
                    return Ok(item);
                }*/
/*        [HttpGet("FilterByAscendingOrder")]
        public async Task<ActionResult<List<HistoryDTO>>> GetFilterAscending()
        {
            var item = await _historyTableService.GetFilterAscending();
            return Ok(item);
        }
        [HttpGet("FilterByDescendingOrder")]
        public async Task<ActionResult<List<HistoryDTO>>> GetFilterDescending()
        {
            var item = await _historyTableService.GetFilterDescending();
            return Ok(item);
        }*/
    }
}
