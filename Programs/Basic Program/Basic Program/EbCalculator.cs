using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class EbCalculator
    {
        private double unit;
        private double charge;

        public double Unit { get => unit; set => unit = value; }
        public double Charge { get => charge; set => charge = value; }

        public void EnterReading()
        {
            Console.WriteLine("Enter the reading");
            this.Unit = Convert.ToDouble(Console.ReadLine());
        }
        public double CalculateBill()
        {
            if (this.Unit < 200)
                this.Charge = 1.20;
            else if (this.Unit >= 200 && this.Unit < 400)
                this.Charge = 1.50;
            else if (this.Unit >= 400 && this.Unit < 600)
                this.Charge = 1.80;
            else
                this.Charge = 2.00;
            return this.Charge;
        }
    }
}
