using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class JaggedArray
    {

        public void display()
        {
            int[][] numbers = new int[4][];
            numbers[0] = new int[] { 1, 2, 3, 4 };
            numbers[1] = new int[] { 11, 22 };
            numbers[2] = new int[] { 1, 2, 3, 4 };
            numbers[3] = new int[] { 1, 2, 3, 4 };

            Console.WriteLine(numbers[1][1]);

            for (int n=0;n<numbers.Length;n++)
            {
                Console.WriteLine("Row {0}", n);
                for (int m = 0; m < numbers[n].Length;m++)
                {
                    Console.Write(numbers[n][m] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void display_multiDimension()
        {
            int[][, ] numbers2 = new int[4][, ]
            {
                new int[, ] {{ 1, 3}, { 5, 7}},
                new int[, ] {{ 0, 2, 1}, { 4, 6, 1}},
                new int[, ] {{ 1, 3}, { 5, 7}},
                new int[, ] {{ 1, 3}, { 5, 7}}
            };
            //Console.WriteLine(numbers2[1][1, 2]) ;

            for (int i=0;i<numbers2.Length;i++)
            {
                int x = 0;
                for(int j = 0; j < numbers2[i].GetLength(x);j++)
                {
                    for(int k = 0; k < numbers2[j].Rank;k++)
                    {
                        Console.Write(numbers2[i][j, k]);
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
        
    }
}
