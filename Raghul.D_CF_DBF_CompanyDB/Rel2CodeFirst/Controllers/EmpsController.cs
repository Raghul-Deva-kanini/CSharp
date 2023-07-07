﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rel2CodeFirst.Models;
using Rel2CodeFirst.Repository.emp;

namespace Rel2CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : ControllerBase
    {
        private readonly IEmpServices _context;

        public EmpsController(IEmpServices context)
        {
            _context = context;
        }

        // GET: api/Emps
        [HttpGet]
        public async Task<IEnumerable<Emp>> Getemps()
        {
         
            return await _context.Getemps();
        }

        // GET: api/Emps/5
        [HttpGet("{id}")]
        public async Task<Emp> GetEmp(int id)
        {
         

            return await _context.GetEmp(id);
        }

        // PUT: api/Emps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<Emp> PutEmp(int id, Emp emp)
        {
            

            return await _context.PutEmp(id, emp);
        }

        // POST: api/Emps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<Emp> PostEmp(Emp emp)
        {
          

            return await _context.PostEmp(emp);
        }

        // DELETE: api/Emps/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteEmp(int id)
        {
           

            return await _context.DeleteEmp(id);
        }

       
    }
}
