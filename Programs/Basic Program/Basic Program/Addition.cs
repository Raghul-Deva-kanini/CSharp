using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Addition
    {
        private static int bon;

        public Addition()
        {
            bon = 6;
        }

        internal static void add(int x, int y, out int n1, out int n2)
        {
            n1 = bon+x;
            n2 = bon+y;
        }
    }
}
