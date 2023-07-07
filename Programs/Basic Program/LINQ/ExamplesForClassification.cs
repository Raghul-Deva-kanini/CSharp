using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class ExamplesForClassification
    {
        public void example1()
        {
            List<string> courses = new List<string>();
            {
                courses.Add("C++ Tutorial");
                courses.Add("C# Tutorial");
                courses.Add("SQL learn");
                courses.Add("Web Tutorial");
                courses.Add("VC++ Tutorial");
                //var tutcourses = from c in courses where c.Contains("Tutorial") select c;

                var tutcourses = courses.Where(c => c.Contains("Tutorial"));

                foreach(var tut in tutcourses)
                {
                    Console.WriteLine(tut);
                }
            }
        }
        public void filteringwhere()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "AAA", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "BBB",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "CCC",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "DDD" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "EEE" , Age = 15 }
            };

            var filteredResult = from s in studentList
                                 where s.Age > 12 && s.Age < 20 select s;
            foreach (var res in filteredResult)
            {
                Console.WriteLine(res.StudentID + " " +  res.Age);
            }
        }

        public void filteringOfType()
        {
            IList elements = new ArrayList();
            elements.Add(1);
            elements.Add("Two");
            elements.Add(3);
            elements.Add(4);
            elements.Add("Five");

            /*
            var strings = from e in elements.OfType<string>()
                          select e;
            var numbers = from e in elements.OfType<Int32>()
                          select e;
            */

            var strings = elements.OfType<string>();
            var numbers = elements.OfType<Int32>();

            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
        }

        public void SortingOrderBy()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "ZZZ", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "BBB",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "BBB",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "YYY" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "ZZZ" , Age = 15 }
            };
            /*
            var result = from student in studentList
                         orderby student.StudentName descending
                         select student;
            */

            var result = studentList.OrderByDescending(s => s.StudentName).ThenBy(s=>s.Age);
            foreach (var std in result)
            {
                Console.WriteLine(std.StudentName + " "+ std.Age);
            }
        }
        public void Grouping()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "ZZZ", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "BBB",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "BBB",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "YYY" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "ZZZ" , Age = 15 }
            };
            /*var result = from s in studentList
                         group s by s.StudentName;*/

            var result = studentList.ToLookup(s=>s.StudentName);
            foreach (var std in result)
            {
                Console.WriteLine(std.Key);
                foreach(var x in std)
                {
                    Console.WriteLine(x.StudentID + " "+ x.Age);
                }
            }

        }   
}
}

