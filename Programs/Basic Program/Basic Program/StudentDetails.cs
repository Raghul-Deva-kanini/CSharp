using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class StudentDetails
    {
        private int roll_no;
        private string name;

        public StudentDetails(int rollno, string name)
        {
            this.Roll_no = rollno;
            this.Name = name;
        }

        public int Roll_no { get => roll_no; set => roll_no = value; }
        public string Name { get => name; set => name = value; }

        public virtual void show()
        {
            Console.WriteLine("Welcome1");
        }
        
    }
}
