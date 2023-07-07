using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    public partial class PartialDemo
    {
        int ans;
        public PartialDemo(int n1, int n2, int ans)
        {
            N1 = n1;
            N2 = n2;
            this.ans = ans;
        }

        public partial int calc()
        {
            Console.WriteLine("Adding : " + N1 + "&" + N2);
            this.ans = N1 + N2;
            return this.ans;
        }
    }
}
