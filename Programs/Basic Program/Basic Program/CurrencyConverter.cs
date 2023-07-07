using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class CurrencyConverter
    {
        public void Conversations()
        {
            Console.WriteLine("Enter the choice for Conversion");
            Console.WriteLine("1. INR to USD \n2. INR to UAE \n3. INR to EURO \n4. INR to AsutralianDollar \n5. INR to SriLankanRupee");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter the Amount");
                    double amount1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{amount1} INR equals " + Math.Round(amount1 * 0.012, 2) + " Dollar");
                    break;
                case 2:
                    Console.WriteLine("Enter the Amount");
                    double amount2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{amount2} INR equals " + Math.Round(amount2 * 0.045, 2) + " Dirham");
                    break;

                case 3:
                    Console.WriteLine("Enter the Amount");
                    double amount3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{amount3} INR equals " + Math.Round(amount3 * 0.011, 2) + " Euro");
                    break;

                case 4:
                    Console.WriteLine("Enter the Amount");
                    double amount4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{amount4} INR equals " + Math.Round(amount4 * 0.018, 2) + " Australian Dollar");
                    break;

                case 5:
                    Console.WriteLine("Enter the Amount");
                    double amount5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{amount5} INR equals " + Math.Round(amount5 * 3.89, 2) + " SriLankan Rupee");
                    break;
               
                default:
                    Console.WriteLine("Please enter from option 1-5");
                    break;
            }
        }
    }
}
