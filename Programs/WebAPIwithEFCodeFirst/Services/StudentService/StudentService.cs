using Microsoft.EntityFrameworkCore;
using WebAPIwithEFCodeFirst.Data;

namespace WebAPIwithEFCodeFirst.Services.StudentService
{
    public class StudentService : IStudentService
    {
        public StudentDataContext _studentDataContext;
        public StudentService(StudentDataContext studentDataContext)
        {
            _studentDataContext = studentDataContext;
        }

        public async Task<List<Student>> GetAllStudentDetails()
        {
            var students = await _studentDataContext.Students.ToListAsync();
            return students;
        }
            
        public async Task<Student?> GetAllStudentDetailById(int id)
        {
            //var srudent = studentsList.Find(s=>s.StudID==id)
            var student = await _studentDataContext.Students.FindAsync(id);

            if (student is null)
            {
                return null;
            }
            return student;
        }
        
        public async Task<List<Student>> AddStudentDetail(Student stud)
        {
            _studentDataContext.Students.Add(stud);
            await _studentDataContext.SaveChangesAsync();
            return await _studentDataContext.Students.ToListAsync();
        }

        public async Task<List<Student>?> UpdateStudentDetailById(int id, Student stud)
        {
            var student = await _studentDataContext.Students.FindAsync(id);
            if (student is null)
            {
                return null;
            }
            student.StudName = stud.StudName;
            student.City = stud.City;
            student.Pin = stud.Pin;

            await _studentDataContext.SaveChangesAsync();
            return await _studentDataContext.Students.ToListAsync();
        }

        public async Task<List<Student>?> DeleteStudentDetailById(int id)
        {
            var student = await _studentDataContext.Students.FindAsync(id);
            if (student is null)
            {
                return null;
            }
            _studentDataContext.Remove(student);
            await _studentDataContext.SaveChangesAsync();
            return await _studentDataContext.Students.ToListAsync();
        }
    }
}
