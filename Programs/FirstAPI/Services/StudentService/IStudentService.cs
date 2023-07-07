
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Services.StudentService
{
    public interface IStudentService
    {
        List<Student> GetAllStudentDetails();
        Student? GetAllStudentDetailById(int id);
        List<Student> AddStudentDetail(Student stud);
        List<Student>? UpdateStudentDetailById(int id, Student stud);
        List<Student>? DeleteStudentDetailById(int id);
    }
}
