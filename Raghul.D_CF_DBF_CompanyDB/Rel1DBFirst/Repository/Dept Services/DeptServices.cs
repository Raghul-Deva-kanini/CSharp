using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rel1.Models;
using System.Reflection;

namespace Rel1.Repository.Dept_Services
{
    public class DeptServices : IDeptServices
    {
        public CompanyContext _companyContext;

        public DeptServices(CompanyContext companyContext)
        {
            _companyContext = companyContext;
        }

        public async Task<List<Dept>?> GetDepts()
        {
            var depts = await _companyContext.Depts.ToListAsync();
            return depts;
        }

        public async Task<Dept>? GetDept(int id)
        {
            var depts = await _companyContext.Depts.FindAsync(id);
            if (depts is null)
            {
                return null;
            }
            return depts; 
        }

        public async Task<List<Dept>?> PutDept(int id, Dept dept)
        {
            var depts = await _companyContext.Depts.FindAsync(id);
            if(depts is null)
            {
                return null;
            }
           
            depts.Deptname = dept.Deptname;

            await _companyContext.SaveChangesAsync();
            return await _companyContext.Depts.ToListAsync();
        }

        public async Task<List<Dept>> PostDept(Dept dept)
        {
            _companyContext.Depts.Add(dept);
            await _companyContext.SaveChangesAsync();
            return await _companyContext.Depts.ToListAsync();
        }

        public async Task<List<Dept>> DeleteDept(int id)
        {
            var dept = _companyContext.Depts.Find(id);
            _companyContext.Remove(dept);
            await _companyContext.SaveChangesAsync();
            return await _companyContext.Depts.ToListAsync();
        }
    }
}
