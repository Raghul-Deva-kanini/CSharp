using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class LoanAccount:Customer
    {
        private int loanAccNo;
        private int loanAmount;
        private int loanTenureinyrs;
        public LoanAccount(int loanAccNo, int loanAmount, int loanTenureinyrs, int custid, string custname):base(custid, custname)
        {
            this.LoanAccNo = loanAccNo;
            this.LoanAmount = loanAmount;
            this.LoanTenureinyrs = loanTenureinyrs;
        }

        public int LoanAccNo { get => loanAccNo; set => loanAccNo = value; }
        public int LoanAmount { get => loanAmount; set => loanAmount = value; }
        public int LoanTenureinyrs { get => loanTenureinyrs; set => loanTenureinyrs = value; }

        public void CustDetails()
        {
            Console.WriteLine("Customer ID : " + this.Custid);
            Console.WriteLine("Customer Name : "+ this.Custname);
            Console.WriteLine("Loan Account Number : "+ this.LoanAccNo);
            Console.WriteLine("Loan Amount : " + this.LoanAmount);
            Console.WriteLine("Tenure in years : " + this.LoanTenureinyrs);
        }
    }
}
