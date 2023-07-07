using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class ExceptionHandling
    {
        int n1, n2, ans;
        public ExceptionHandling(int n1, int n2, int ans)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.ans = ans;
        }

        

        public int add()
        {
            this.ans = this.n1 + this.n2;
            return this.ans;
        }

        public int mul()
        {
            this.ans = this.n1 * this.n2;
            return this.ans;
        }

        public int div()
        {
            int[] num = { 10, 0 };
            try
            {
                this.ans = this.n1 / this.n2;
                int x = num[0] + num[1] + num[2];
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Don't give 0 in the denominator");
            }

            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
            }

            
            finally
            {
                Console.WriteLine("Done");
            }

            return this.ans;
        }

        public void CheckVal(int val)
        {
            if (val<0)
            {
                throw new ArgumentException("Don't pass negative value");
            }
            else if (val<18)
            {
                throw new ArithmeticException("You are not eligible to vote");
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }
    }
}
