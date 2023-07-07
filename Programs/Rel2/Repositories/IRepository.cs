using Rel2.models;

namespace Rel2.Repositories
{
    public interface IRepository
    {
        public Task<List<Dept>?> GetAllDept();

        public Task<Dept?> GetDept(int id);

        public Task<List<Dept>?> PutDept(int id, Dept dept);

        public Task<List<Dept>> PostDept(Dept dept);

        public Task<List<Dept>> DeleteDept(int id);

        public Task<List<Emp>?> GetAllEmp();

    }
}
