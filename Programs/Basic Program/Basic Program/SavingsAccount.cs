using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class SavingsAccount:Customer
    {
        private int accno;
        private double amount;
        private string branchname;
        private string ifsc;

        public SavingsAccount(int accno, double amount, string branchname, string ifsc, int custid, string custname) :base(custid, custname)
        {
            this.Accno = accno;
            this.Amount = amount;
            this.Branchname = branchname;
            this.Ifsc = ifsc;
        }

        public int Accno { get => accno; set => accno = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Branchname { get => branchname; set => branchname = value; }
        public string Ifsc { get => ifsc; set => ifsc = value; }


        public void CustDetails()
        {
            Console.WriteLine("Customer ID : " + this.Custid);
            Console.WriteLine("Customer Name : " + this.Custname);
            Console.WriteLine("Account number :" + this.Accno);
            Console.WriteLine("Amount : " + this.Amount);
            Console.WriteLine("Branch Name : " + this.Branchname);
            Console.WriteLine("IFSC code : " + this.Ifsc);
        }
    }
}
