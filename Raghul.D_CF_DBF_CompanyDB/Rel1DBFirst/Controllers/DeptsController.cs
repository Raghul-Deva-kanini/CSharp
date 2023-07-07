using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rel1.Models;
using Rel1.Repository.Dept_Services;

namespace Rel1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptsController : ControllerBase
    {
        private readonly IDeptServices _deptServices;
        public DeptsController(IDeptServices deptServices)
        {
            _deptServices = deptServices;
        }

        // GET: api/Depts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dept>?>> GetDepts()
        {
            return await _deptServices.GetDepts();
        }

        // GET: api/Depts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dept>> GetDept(int id)
        {
            var dept = await _deptServices.GetDept(id);

            if (dept == null)
            {
                return NotFound("Dept id not matching");
            }

            return Ok(dept);
        }

        
        // PUT: api/Depts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<List<Dept>?> PutDept(int id, Dept dept)
        {
            return await _deptServices.PutDept(id, dept);
        }

        
        // POST: api/Depts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dept>> PostDept(Dept dept)
        {
            var depts = await _deptServices.PostDept(dept);
            return Ok(depts);
        }
        
        // DELETE: api/Depts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Dept>>> DeleteDept(int id)
        {
            var dept = await _deptServices.DeleteDept(id);

            if (dept == null)
            {
                return NotFound("Dept id not matching");
            }

            return Ok(dept);
        }
    }
}
