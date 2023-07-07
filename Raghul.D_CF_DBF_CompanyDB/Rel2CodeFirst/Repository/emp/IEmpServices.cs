using Microsoft.AspNetCore.Mvc;
using Rel2CodeFirst.Models;

namespace Rel2CodeFirst.Repository.emp
{
    public interface IEmpServices
    {

        Task<IEnumerable<Emp>> Getemps();
        Task<Emp> GetEmp(int id);
        Task<Emp> PutEmp(int id, Emp emp);
        Task<Emp> PostEmp(Emp emp);
        Task<string> DeleteEmp(int id);
        
        }
}
