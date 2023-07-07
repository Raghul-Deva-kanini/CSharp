using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rel1.Models;
using Rel1.Repository.Emp_Services;

namespace Rel1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : ControllerBase
    {
        private readonly IEmpServices _empServices;

        public EmpsController(IEmpServices empServices)
        {
            _empServices = empServices;
        }

        // GET: api/Emps
        [HttpGet]
        public async Task<ActionResult<List<Emp>>> GetEmps()
        {
            return await _empServices.GetEmps();
        }

        // GET: api/Emps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emp>> GetEmp(int id)
        {
            var emp = await _empServices.GetEmp(id);

            if (emp == null)
            {
                return NotFound("Dept id not matching");
            }

            return Ok(emp);
        }

        // PUT: api/Emps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        
        public async Task<List<Emp>?> PutEmp(int id, Emp emp)
        {
            return await _empServices.PutEmp(id, emp);
        }

        
        // POST: api/Emps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Emp>> PostEmp(Emp emp)
        {
            var emps = await _empServices.PostEmp(emp);
            return Ok(emps);
        }

        
        // DELETE: api/Emps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmp(int id)
        {
            var emp = await _empServices.DeleteEmp(id);

            if (emp == null)
            {
                return NotFound("Dept id not matching");
            }

            return Ok(emp);
        }

    }
}
