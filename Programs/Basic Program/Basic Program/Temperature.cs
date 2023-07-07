using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Temperature
    {
        public void Conversion()
        {
            Console.WriteLine("1. Celsius to Farenheit Conversion \n2. Farenheit to Celsius COnversion");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter the Temperature in Celsius");
                    double temp1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine((temp1 * 9 / 5) + 32 + "Deg Farenheit");
                    break;

                case 2:
                    Console.WriteLine("Enter Fahrenheit Temperature:");
                    double Fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
                    double Celsius = Math.Round((Fahrenheit - 32) * 5 / 9, 2);
                    Console.WriteLine("The converted Celsius temperature is:" + Celsius);
                    break;

            }
        }
    }
}
