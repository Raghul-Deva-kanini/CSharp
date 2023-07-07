using Microsoft.AspNetCore.Mvc;
using Rel2CodeFirst.Models;

namespace Rel2CodeFirst.Repository.dept
{
    public interface IDeptServices
    {

        Task<IEnumerable<Dept>> GetDepts();
        Task<Dept> GetDept(int id);
         Task<Dept> PutDept(int id, Dept dept);
        Task<Dept> PostDept(Dept dept);
        Task<string> DeleteDept(int id);
    }
}
