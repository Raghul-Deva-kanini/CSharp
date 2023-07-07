using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Customer
    {
        private int custid;
        private string custname;

        public Customer(int custid, string custname) 
        {
               this.Custid = custid;
               this.Custname = custname;
        }

        public int Custid { get => custid; set => custid = value; }
        public string Custname { get => custname; set => custname = value; }

        public void CustDetails()
        {
            Console.WriteLine(this.Custid);
            Console.WriteLine(this.Custname);
        }
    }
}
