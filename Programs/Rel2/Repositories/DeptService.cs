using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rel2.models;

namespace Rel2.Repositories
{
    public class DeptService:IRepository
    {
        public CompanyContextCF _companyContextCF;
        
        public DeptService(CompanyContextCF companyContextCF)
        {
            _companyContextCF = companyContextCF;
        }

        public async Task<List<Dept>?> GetAllDept()
        {
            var depts = await _companyContextCF.Depts.ToListAsync();
            return depts;
        }

        public async Task<Dept?> GetDept(int id)
        {
            var depts = await _companyContextCF.Depts.FindAsync(id);
            if (depts is null)
            {
                return null;
            }
            return depts;
        }

        public async Task<List<Dept>?> PutDept(int id, Dept dept)
        {
            var depts = await _companyContextCF.Depts.FindAsync(id);
            if (depts is null)
            {
                return null;
            }

            depts.Deptname = dept.Deptname;

            await _companyContextCF.SaveChangesAsync();
            return await _companyContextCF.Depts.ToListAsync();
        }

        public async Task<List<Dept>> PostDept(Dept dept)
        {
            _companyContextCF.Depts.Add(dept);
            await _companyContextCF.SaveChangesAsync();
            return await _companyContextCF.Depts.ToListAsync();
        }

        public async Task<List<Dept>> DeleteDept(int id)
        {
            var dept = _companyContextCF.Depts.Find(id);
            _companyContextCF.Remove(dept);
            await _companyContextCF.SaveChangesAsync();
            return await _companyContextCF.Depts.ToListAsync();
        }
    }
}
