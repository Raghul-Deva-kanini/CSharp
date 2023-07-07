using Microsoft.AspNetCore.Mvc;
using Rel1.Models;

namespace Rel1.Repository.Dept_Services
{
    public interface IDeptServices
    {
        Task<List<Dept>?> GetDepts();
        Task<Dept>? GetDept(int id);
        Task<List<Dept>?> PutDept(int id, Dept dept);
        Task<List<Dept>> PostDept(Dept dept);
        Task<List<Dept>> DeleteDept(int id);
    }
}
