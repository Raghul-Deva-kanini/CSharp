using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class StudentCalculation : StudentMarks
    {
        private double total, avg;

        public StudentCalculation(int rollno, string name, double mark1, double mark2, double mark3, double total=0, double avg = 0):base(rollno, name, mark1, mark2, mark3)
        {
            
            this.Total = total; 
            this.Avg = avg;
        }
        public double Total { get => total; set => total = value; }
        public double Avg { get => avg; set => avg = value; }

        public void Calculate()
        {
            this.Total = this.Mark1 + this.Mark2 + this.Mark3;
            this.Avg = this.Total / 3;
        }

        /*public override void show()
        {
            Console.WriteLine("Howdy");
        }*/

       /* public override void show()
        {
            Console.WriteLine("Howdy");
        }*/

    }
}
