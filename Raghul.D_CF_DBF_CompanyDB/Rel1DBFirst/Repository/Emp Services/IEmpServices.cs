using Rel1.Models;

namespace Rel1.Repository.Emp_Services
{
    public interface IEmpServices
    {
       Task<List<Emp>> GetEmps();
       Task<Emp> GetEmp(int id);
       Task<List<Emp>?> PutEmp(int id, Emp emp);
       Task<List<Emp>> PostEmp(Emp emp);
       Task<List<Emp>> DeleteEmp(int id);
    }
}
