using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class AdminStaff:College
    {
        private int empid;
        private string name;
        private double salary;

        public AdminStaff(int empid, string name, double salary, string collegeName, string address, int pincode):base(collegeName, address, pincode)
        {
            this.Empid = empid;
            this.Name = name;
            this.Salary = salary;
        }

        public int Empid { get => empid; set => empid = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public double calculate_salary()
        {
            double da = 0.3; double hra = 1.5;
            double allowances = (salary * da) + (salary * hra);
            double epf = 0.2;
            double deductions = salary * epf;
            double netSalary = salary + allowances - deductions;
            return netSalary;
        }
    }
}
