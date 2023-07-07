using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Interest:BankDetails
    {
        private int intpercent;

        public Interest(int intpercent, int acc, string acname, double balance, double intamt):base(acc, acname, balance, intamt)
        {
            this.Intpercent = intpercent;
        }

        public int Intpercent { get => intpercent; set => intpercent = value; }

   /*     public override double CalculateInterest()
        {
            return Balance * ((double)Intpercent / 100);
        }
   */
    }
}
