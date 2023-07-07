using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class DerivedAbstractClass:AbstractClass
    {
        public override void display()
        {
            Console.WriteLine("Welcome Boss");
        }
    }
}
