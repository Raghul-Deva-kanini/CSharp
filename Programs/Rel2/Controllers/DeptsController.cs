using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rel2.models;
using Rel2.Repositories;

namespace Rel2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptsController : ControllerBase
    {
        private readonly IRepository _repo;

        public DeptsController(IRepository repo)
        {
            _repo = repo;
        }

        // GET: api/Depts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dept>?>> GetAllDept()
        {
            return await _repo.GetAllDept();
        }

        // GET: api/Depts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dept>> GetDept(int id)
        {
          var dept = await _repo.GetDept(id);
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
            return await _repo.PutDept(id, dept);
        }

        // POST: api/Depts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dept>> PostDept(Dept dept)
        {
            var depts = await _repo.PostDept(dept);
            return Ok(depts);
        }

        // DELETE: api/Depts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Dept>>> DeleteDept(int id)
        {
            var dept = await _repo.DeleteDept(id);

            if (dept == null)
            {
                return NotFound("Dept id not matching");
            }

            return Ok(dept);
        }
    }
}
