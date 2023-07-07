using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rel2.models;

namespace Rel2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpDetailsController : ControllerBase
    {
        private readonly CompanyContextCF _context;

        public EmpDetailsController(CompanyContextCF context)
        {
            _context = context;
        }

        // GET: api/EmpDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpDetails>>> GetEmpDetails_1()
        {
          if (_context.EmpDetails_1 == null)
          {
              return NotFound();
          }
            return await _context.EmpDetails_1.ToListAsync();
        }

        // GET: api/EmpDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpDetails>> GetEmpDetails(int id)
        {
          if (_context.EmpDetails_1 == null)
          {
              return NotFound();
          }
            var empDetails = await _context.EmpDetails_1.FindAsync(id);

            if (empDetails == null)
            {
                return NotFound();
            }

            return empDetails;
        }

        // PUT: api/EmpDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpDetails(int id, EmpDetails empDetails)
        {
            if (id != empDetails.empno)
            {
                return BadRequest();
            }

            _context.Entry(empDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EmpDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpDetails>> PostEmpDetails(EmpDetails empDetails)
        {
          if (_context.EmpDetails_1 == null)
          {
              return Problem("Entity set 'CompanyContextCF.EmpDetails_1'  is null.");
          }
            _context.EmpDetails_1.Add(empDetails);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmpDetailsExists(empDetails.empno))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmpDetails", new { id = empDetails.empno }, empDetails);
        }

        // DELETE: api/EmpDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpDetails(int id)
        {
            if (_context.EmpDetails_1 == null)
            {
                return NotFound();
            }
            var empDetails = await _context.EmpDetails_1.FindAsync(id);
            if (empDetails == null)
            {
                return NotFound();
            }

            _context.EmpDetails_1.Remove(empDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpDetailsExists(int id)
        {
            return (_context.EmpDetails_1?.Any(e => e.empno == id)).GetValueOrDefault();
        }
    }
}
