using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class LambdaExpression
    {

        public void evennumbers()
        {
            List<int> numbers = new List<int>() { 10, 5, 3, 2, 1, 7, 8 };
            List<int> evennum = numbers.FindAll(n => ((n % 2) == 0));

            foreach (int n in evennum)
            {
                Console.WriteLine(n);
            }
        }
       
    }
}
