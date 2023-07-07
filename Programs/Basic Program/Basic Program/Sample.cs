using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Sample : Addcon
    {
        public int intadd(int n1, int n2=0)   
        {
            return n1 + n2;
        }

        public string stradd(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
