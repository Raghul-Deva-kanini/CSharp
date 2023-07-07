using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Consecutives
    {
        public void display_consecutives(string input)
        {
            string output = "";
            int count = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    output += input[i - 1] + count.ToString();
                    count = 1;
                }
            }
            output += input[input.Length - 1] + count.ToString();

            Console.WriteLine("Output : ");
            Console.WriteLine(output.ToLower());
        }
    }
}
