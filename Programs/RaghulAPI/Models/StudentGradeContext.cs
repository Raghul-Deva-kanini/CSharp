using Microsoft.EntityFrameworkCore;
using System.Data;

namespace RaghulAPI.Models
{
    public class StudentGradeContext:DbContext
    {
        public StudentGradeContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Student> Students { get;set; }

        public DbSet<Grade> Grades { get;set; }


    }
}
