﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    public class BankTransactions
    {
        private int custid;
        private long accno;
        private string accname, status;
        private decimal balance, creditamt, debitamt;

        public int Custid { get => custid; set => custid = value; }
        public long Accno { get => accno; set => accno = value; }
        public string Accname { get => accname; set => accname = value; }
        public string Status { get => status; set => status = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public decimal Creditamt { get => creditamt; set => creditamt = value; }
        public decimal Debitamt { get => debitamt; set => debitamt = value; }

        public BankTransactions(int custid, long accno, string accname, decimal balance)
        {
            this.Custid= custid; 
            this.Accno = accno; 
            this.Balance = balance; 
            this.Accname = accname;
            this.Status = "Inactive";
            this.Creditamt = this.Debitamt = 0;
        }
        
        internal decimal PerformTransactions()
        {
            Console.WriteLine("1. Credit 2.Debit");
            int ch = Convert.ToInt32(Console.ReadLine());
            
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter the credit amount");
                    this.Creditamt = Convert.ToDecimal(Console.ReadLine());
                    this.Balance += this.Creditamt;
                    this.Status = "Active";
                    break;
                case 2:
                    Console.WriteLine("Enter the debit amount");
                    this.Debitamt = Convert.ToDecimal(Console.ReadLine());
                    this.Balance -= this.Debitamt;
                    this.Status = "Active";
                    break;
                default:
                    Console.WriteLine("Enter 1 or 2");
                    break;
            }
            return this.Balance;
        }

        internal void displayCustomerDetails()
        {
            PerformTransactions();
            Console.WriteLine($"Custid : {Custid}");
            Console.WriteLine($"Accno : {Accno}");
            Console.WriteLine($"Accname : {Accname}");
            Console.WriteLine($"Status : {Status}");
            Console.WriteLine($"Balance : {Balance}");
        }
    }
}*/
