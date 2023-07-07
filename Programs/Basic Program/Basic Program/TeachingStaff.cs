using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class TeachingStaff:College
    {
        private int empid;
        private string name, dept, favsub;
        private double salary;


        public TeachingStaff(int empid, string name, string dept, string favsub, double salary, string collegeName, string address, int pincode):base(collegeName, address, pincode)
        {
            this.Empid = empid;
            this.Name = name;
            this.Dept = dept;
            this.Favsub = favsub;
            this.Salary = salary;
        }

        public int Empid { get => empid; set => empid = value; }
        public string Name { get => name; set => name = value; }
        public string Dept { get => dept; set => dept = value; }
        public string Favsub { get => favsub; set => favsub = value; }
        public double Salary { get => salary; set => salary = value; }

        public double calculate_salary()
        {
            double da = 0.4; double hra = 0.2;
            double allowances =  (salary*da) + (salary*hra);
            double epf = 0.25;
            double deductions = salary * epf;
            double netSalary = salary + allowances - deductions;
            return netSalary;
        }
    }
}
