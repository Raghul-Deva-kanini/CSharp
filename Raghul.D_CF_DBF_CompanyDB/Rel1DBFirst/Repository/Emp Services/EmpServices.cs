using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rel1.Models;

namespace Rel1.Repository.Emp_Services
{
    public class EmpServices:IEmpServices
    {
        public CompanyContext _companyContext;

        public EmpServices(CompanyContext companyContext)
        {
            _companyContext= companyContext;
        }

        public async Task<List<Emp>> GetEmps()
        {
            var emps = await _companyContext.Emps.ToListAsync();
            return emps;
        }

        public async Task<Emp> GetEmp(int id)
        {
            var emp = await _companyContext.Emps.FindAsync(id);
            if (emp is null)
            {
                return null;
            }
            return emp;
        }

        public async Task<List<Emp>?> PutEmp(int id, Emp emp)
        {
            var emps = await _companyContext.Emps.FindAsync(id);
            if (emps is null)
            {
                return null;
            }

            emps.Ename = emp.Ename;
            emps.Deptno = emp.Deptno;

            await _companyContext.SaveChangesAsync();
            return await _companyContext.Emps.ToListAsync();
        }


        public async Task<List<Emp>> PostEmp(Emp emp)
        {
            _companyContext.Emps.Add(emp);
            await _companyContext.SaveChangesAsync();
            return await _companyContext.Emps.ToListAsync();
        }

        public async Task<List<Emp>> DeleteEmp(int id)
        {
            var emp = _companyContext.Emps.Find(id);
            _companyContext.Remove(emp);
            await _companyContext.SaveChangesAsync();
            return await _companyContext.Emps.ToListAsync();
        }

    }
}
