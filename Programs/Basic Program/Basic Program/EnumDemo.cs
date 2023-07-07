using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class EnumDemo
    {
        enum Colors
        {
            ff000, fff, ff00
        }

        public void display()
        {
            Colors red = Colors.ff000;
            Colors green = Colors.fff;
            Colors blue = Colors.ff000;
            Console.WriteLine("My car is "+ red);
            Console.WriteLine("My car is " + green);

        }
    }
}
