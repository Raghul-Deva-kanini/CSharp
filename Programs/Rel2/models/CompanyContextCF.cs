using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Rel2.models;

namespace Rel2.models
{
    public class CompanyContextCF:DbContext
    {
        public CompanyContextCF(DbContextOptions<CompanyContextCF>options):base(options)
        {

        }

        public DbSet<Dept> Depts { get; set; }  

        public DbSet<Emp> Emps { get; set; }

        public DbSet<Emp> EmpDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Rel2.models.EmpDetails> EmpDetails_1 { get; set; } = default!;
    }
}
