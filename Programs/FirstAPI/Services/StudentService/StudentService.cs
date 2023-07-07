using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private static List<Student> studentsList = new List<Student>
        {
            new Student {StudID = 1, StudName = "Raj", City="Chennai", Pin=641001},
            new Student {StudID = 2, StudName = "Ram", City = "Cbe", Pin = 641002}
        };

        public List<Student> GetAllStudentDetails()
        {
            return studentsList;
        }

        public Student? GetAllStudentDetailById(int id)
        {
            //var srudent = studentsList.Find(s=>s.StudID==id)
            var student = studentsList.Where(s => s.StudID == id).FirstOrDefault();

            if (student is null)
            {
                return null;
            }
            return student;
        }

        public List<Student> AddStudentDetail(Student stud)
        {
            studentsList.Add(stud);
            return studentsList;
        }

        public List<Student>? UpdateStudentDetailById(int id, Student stud)
        {
            var student = studentsList.Find(s => s.StudID == id);
            if (student is null)
            {
                return null;
            }
            student.StudName = stud.StudName;
            student.City = stud.City;
            student.Pin = stud.Pin;

            return studentsList;
        }

        public List<Student>? DeleteStudentDetailById(int id)
        {
            var student = studentsList.Find(s => s.StudID == id);
            if (student is null)
            {
                return null;
            }
            studentsList.Remove(student);
            return studentsList;
        }
    }
}
