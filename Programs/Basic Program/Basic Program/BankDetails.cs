using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    //abstract internal class BankDetails
    internal class BankDetails
    {
        private int acc;
        private string acname;
        private double balance;
        private double intamt;
        
        public BankDetails(int acc, string acname, double balance, double intamt)
        {
            this.Acc = acc;
            this.Acname = acname;
            this.Balance = balance;
            this.Intamt = intamt;
        }

        public int Acc { get => acc; set => acc = value; }
        public string Acname { get => acname; set => acname = value; }
        public double Balance { get => balance; set => balance = value; }
        public double Intamt { get => intamt; set => intamt = value; }

        //public abstract double CalculateInterest();

        public void bank_regex()
        {
            List<BankDetails> accounts = new List<BankDetails>()
            {   
                new BankDetails(12345, "ABC", 10000, 0),
                new BankDetails(12346, "BCD", 20000, 0),
            };
            var names = accounts.Select(x => x.Acc);
            //var bal = accounts.Select(x => x.Balance);
            foreach (var i in names)
            { 
                Console.WriteLine(i);
            }

        }
    }
}
